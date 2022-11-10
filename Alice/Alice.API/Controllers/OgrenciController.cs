using Alice.Business.Abstract;
using Alice.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Alice.API.Controllers
{
    [Authorize]
    [Route("api")]
    public class OgrenciController : Controller
    {
        IOgrenciService ogr;
        public OgrenciController(IOgrenciService _ogr)
        {
            ogr = _ogr;
        }


        /// <summary>
        /// GET ALL OGRENCI
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("[action]")]
        public IActionResult GetAllOgrenci()
        {
            var ogrenci = ogr.GetAllOgrenci();
            return Ok(ogrenci);
        }


        /// <summary>
        /// GET OGRENCİ BY ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet, Route("[action]/{id}")]
        public IActionResult GetOgrenciById(int id)
        {
            var ogrenci = ogr.GetOgrenciById(id);
            if (ogrenci != null) return Ok(ogrenci);
            else return NotFound();
        }


        [HttpGet, Route("[action]/{name}")]

        public IActionResult GetOgrenciByName(string name)
        {
            var ogrenci = ogr.GetOgrenciByName(name);
            if (ogr != null) return Ok(ogrenci);
            else return NotFound();
        }



        /// <summary>
        /// CREATE A NEW OGRENCI
        /// </summary>
        /// <param name="_ogrenci"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(Ogrenci _ogrenci)
        {
            if (ModelState.IsValid)
            {
                var ogrenci = ogr.CreateOgrenci(_ogrenci);
                return CreatedAtAction("Get", new { id = ogrenci.ID }, ogrenci);
            }
            return BadRequest(ModelState);             
        }


        /// <summary>
        /// UPDATE THE OGRENCI
        /// </summary>
        /// <param name="ogrenci"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Update(Ogrenci ogrenci)
        {
            if (ogr.GetOgrenciById(ogrenci.ID) != null) return Ok(ogr.UpdateOgrenci(ogrenci));
            else return NotFound();
        }


        /// <summary>
        /// DELETE THE OGRENCI WİTH BY ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("id")]

        public IActionResult Delete(int id)
        {
            if (ogr.GetOgrenciById(id) != null)
            {
                ogr.DeleteOgrenciById(id);
                return Ok();
            }
            else return NotFound();
        }





    }
}
