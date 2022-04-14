using Microsoft.AspNetCore.Mvc;
using TreinamentoBack.Service;

namespace TreinamentoBack.WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T, K> : ControllerBase, IDisposable where T : class where K : notnull
    {
        private bool disposedValue;

        public BaseService<T> BaseService { get; set; }

        public BaseController(BaseService<T> Baseservice)
        {
            BaseService = Baseservice;
        }

        [HttpGet]
        public virtual IEnumerable<T> Get()
        {
            return BaseService.List();
        }

        [HttpGet("{Id}")]

        public T Get(int id)
        {
            return BaseService.Recover(id);
        }

        [HttpPost]
        public void Post([FromBody] T Model)
        {
            BaseService.Insert(Model);
        }

        [HttpPut("{id}")]

        public void Put(K id, [FromBody] T Model)
        {
            BaseService.Update(Model);
        }

        [HttpDelete("{id}")]

        public virtual void Delete(K id)
        {
            BaseService.Delete(id);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (BaseService != null)
                    {
                        BaseService.Dispose();
                    }

                }
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        

    }
}

