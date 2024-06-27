using System.Text.Json;

namespace Application.Commons
{
	public class CustomValidationException : Exception
    {
        public CustomValidationException(List<CustomValidationModel> messages) : base(JsonSerializer.Serialize(messages)) { }
    }
}

