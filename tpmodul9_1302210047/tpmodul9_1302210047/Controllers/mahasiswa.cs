using Microsoft.AspNetCore.Mvc;
using tpmodul9_1302210047;

namespace tpmodul9_1302210047.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class mahasiswa : ControllerBase
    {
        public static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("ROZAN", "1302210047"),
            new Mahasiswa("PRIMA", "1302210001"),
            new Mahasiswa("NADHIFA", "130221001000"),
            new Mahasiswa("SHIELDA", "1302210046"),
            new Mahasiswa("RAFKHA", "13022100182673")
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            dataMahasiswa.Add(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Mahasiswa value)
        {
            dataMahasiswa[id] = value;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}
