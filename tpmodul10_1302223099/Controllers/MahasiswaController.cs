using Microsoft.AspNetCore.Mvc;

namespace tpmodul10_1302223099.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {

        private static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Muhammad Bintang Al-Fath", "130223099"),
            new Mahasiswa("Wildan Syukri Ni'am", "130220005"),
            new Mahasiswa("Arga Adolf Lumunon", "130223038"),
            new Mahasiswa("Faris Azhar Dwiputra", "1302223123"),
            new Mahasiswa("Farah Amalia Putri", "1302223137")
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMahasiswa;
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            dataMahasiswa.Add(value);
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }

    }    
}


