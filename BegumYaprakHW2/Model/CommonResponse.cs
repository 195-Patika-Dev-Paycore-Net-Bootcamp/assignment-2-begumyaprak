using System;
namespace BegumYaprakHW2.Model
{
    public class CommonResponse<Entity> where Entity : class
    {
        public CommonResponse()
        {

        }
        public CommonResponse(Entity data)
        {
            Data = data;
        }
        public CommonResponse(string error)
        {
            Error = error;
            Success = false;
        }
        public bool Success { get; set; } = true;
        public string Error { get; set; }
        public Entity Data { get; set; }
    }
}

