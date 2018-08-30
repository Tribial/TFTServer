using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TFTServer.Shared.ModelsDto
{
    public class Response<T> where T : BaseDto
    {
        public T Object { get; set; }
        public List<string> Errors { get; set; }
        public bool ErrorOccurred => Errors.Any();

        public Response()
        {
            Errors = new List<string>();
        }
    }
}
