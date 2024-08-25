using api.Models.Response;
using binovi.cloud.api.models.Models.Request;
using binovi.cloud.azure.Enums;
using binovi.cloud.Enums;
using binovi.cloud.Exceptions;
using binovi.cloud.Interfaces;
using binovi.cloud.Models.Request;
using binovi.cloud.Models.Response;
using binovi.cloud.Utils;
using ehapi.Authentication;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using System.Web.Hosting;
using System.Web.Http;
using System.Web.Http.Description;

namespace binovi.cloud.Controllers
{
    /// <summary>
    /// Manage Patients for an Organization
    /// </summary>

    [ClaimsAuthorize(ClaimType.Developer, ClaimType.AccessConsumerApp, ClaimType.AdministerAdministrators)]
    [RoutePrefix("api/mediaFiles")]
    public class MediaController : ApiController
    {
        #region Dependency Injection
        private IMediaFileRepo _repository;

        public MediaController(IMediaFileRepo repository)
        {
            _repository = repository;
		}

        #endregion



        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ResponseType(typeof(BaseResponse<string>))]
        [Route("token")]
        public IHttpActionResult GetMediaToken(int mediaFileId)
        {
            BaseResponse<string> result = null;

            try
            {
                string environment = ConfigurationUtils.ApiEnvironment;
                result = _repository.GetMediaToken(environment, mediaFileId);

                return new HttpActionResultEC<string>(Request, result);
            }
            catch (Exception ex)
            {
                return new HttpActionResultError(ex, Request);
            }
        }

    }
}
