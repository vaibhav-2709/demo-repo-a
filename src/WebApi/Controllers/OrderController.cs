using Newtonsoft.Json;

namespace WebApi.Controllers
{
    public class OrderController
    {
        public string Serialize(object order) => JsonConvert.SerializeObject(order);
    }
}
