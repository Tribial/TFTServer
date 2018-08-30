using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TFTServer.Shared.ModelsDto
{
    public class Responses<T> where T : BaseDto
    {
        public List<T> Objects;
        public List<string> Errors { get; set; }
        public bool ErrorOccurred => Errors.Any();

        public Responses()
        {
            Errors = new List<string>();
        }
    }
}
