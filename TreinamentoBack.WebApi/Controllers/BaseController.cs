using Microsoft.AspNetCore.Mvc;
using TreinamentoBack.Service;

namespace TreinamentoBack.WebApi.Controllers
{


    [Route("api/[conytroller]")]
    [ApiController]

    public class BaseController<T, K> : ControllerBase, IDisposable where T : class where K : notnull
    {
        private bool disposedValue;

        public BaseService<T> Service { get; set; }

        public BaseController(BaseService<T> service)
        {
            Service = service;
        }

        [HttpGet]
        public virtual IEnumerable<T> Get()
        {
            return Service.List();
        }

        [HttpGet("{Id}")]

        public virtual T Get(int id)
        {
            return Service.Recover(id);
        }

        [HttpPost]
        public virtual void Post([FromBody] T Model)
        {
            Service.Insert(Model);
        }

        [HttpGet]

        public virtual void Put(K id, [FromBody] T Model)
        {
            Service.Update(Model);
        }

        [HttpDelete("{id}")]

        public virtual void Delete(K id)
        {
            Service.Delete(id);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (Service != null)
                    {
                        Service.Dispose();
                    }

                }
                disposedValue = true;
            }
        }
        public virtual void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddSwaggerGen();

        }

    }
}

