using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Core.Exceptions.Extensions
{
    public static class ProblemDetailsExtension
    {
        // TProblemDetail türünden bir nesneyi JSON formatına dönüştüren uzantı metodu
        public static string AsJson<TProblemDetail>(this TProblemDetail problemDetails)
        where TProblemDetail : ProblemDetails => JsonSerializer.Serialize(problemDetails);
        // JsonSerializer sınıfını kullanarak nesneyi JSON formatına dönüştürme
    }
}
