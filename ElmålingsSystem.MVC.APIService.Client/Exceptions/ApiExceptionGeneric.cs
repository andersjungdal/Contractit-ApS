using MyNamespace;

[System.CodeDom.Compiler.GeneratedCode("NSwag", "13.1.3.0 (NJsonSchema v10.0.27.0 (Newtonsoft.Json v12.0.0.0))")]
public partial class ApiException<TResult> : ApiException
{
    public TResult Result { get; private set; }

    public ApiException(string message, int statusCode, string response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, TResult result, System.Exception innerException)
        : base(message, statusCode, response, headers, innerException)
    {
        Result = result;
    }
}