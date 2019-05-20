using API.Models;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    [RoutePrefix("api/nhaphang")]
    public class NhapHangController : ApiController
    {
        private ShopTTEntities _shopDBEntities = new ShopTTEntities();
        [HttpPost]
        [Route("InsertPhDat")]
        public HttpResponseMessage InsertPhDat(PH_PhieuDatHang datHang)
        {
            try
            {
                var result =  new HttpResponseMessage(HttpStatusCode.OK);
                _shopDBEntities.PH_PhieuDatHang.Add(datHang);
                _shopDBEntities.SaveChanges();
                return result;
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

        [HttpPost]
        [Route("InsertCTPhDat")]
        public HttpResponseMessage InsertCTPhDat(PH_CT_PhieuDat ph_ct_PhieuDat)
        {
            try
            {
                var result = new HttpResponseMessage(HttpStatusCode.OK);
                _shopDBEntities.PH_CT_PhieuDat.Add(ph_ct_PhieuDat);
                _shopDBEntities.SaveChanges();
                return result;
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
    }
}
