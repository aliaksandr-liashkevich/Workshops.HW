using System.Net;
using System.Web.Http;
using FluentValidation;
using Rocket.BL.Common.Models.PersonalArea;
using Rocket.BL.Common.Services.PersonalArea;
using Rocket.Web.Extensions;
using Rocket.Web.Properties;
using Swashbuckle.Swagger.Annotations;

namespace Rocket.Web.Controllers.PersonalArea
{
    [RoutePrefix("")]
    public class TvGenresController : ApiController
    {
        private IGenreManagerService<Genre> _tvGenreManagerService;

        public TvGenresController(IGenreManagerService<Genre> tvGenreManagerService)
        {
            _tvGenreManagerService = tvGenreManagerService;
        }

        [HttpGet]
        [Route("genres/all/tv")]
        public IHttpActionResult GetAllTvGenres()
        {
            var tvGenres = _tvGenreManagerService.GetAllGenres();
            return tvGenres == null ? (IHttpActionResult)NotFound() : Ok(tvGenres);
        }

        [HttpPut]
        [Route("personal/genres/tv/add")]
        [SwaggerResponseRemoveDefaults]
        [SwaggerResponse(HttpStatusCode.BadRequest, "Genre is not valid", typeof(string))]
        public IHttpActionResult SaveTvGenre(string genre)
        {
            if (string.IsNullOrWhiteSpace(genre))
            {
                return BadRequest(Resources.EmptyGenre);
            }

            try
            {
                _tvGenreManagerService.AddGenre(User.GetUserId(), genre);
            }
            catch (ValidationException exception)
            {
                return BadRequest(exception.Message);
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        [HttpPut]
        [Route("personal/genres/tv/delete")]
        [SwaggerResponseRemoveDefaults]
        [SwaggerResponse(HttpStatusCode.BadRequest, "Genre is not valid", typeof(string))]
        public IHttpActionResult DeleteTvGenre(string id, string genre)
        {
            if (string.IsNullOrWhiteSpace(genre))
            {
                return BadRequest(Resources.EmptyGenre);
            }

            try
            {
                _tvGenreManagerService.DeleteGenre(User.GetUserId(), genre);
            }
            catch (ValidationException exception)
            {
                return BadRequest(exception.Message);
            }

            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
