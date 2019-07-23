﻿using System;
using System.Linq;
using NJsonSchema;
using NSwag;
using NSwag.Generation.Processors;
using NSwag.Generation.Processors.Contexts;
using NV.Templates.Backend.RestApi.Framework.Middlewares;
using NV.Templates.Backend.RestApi.Framework.Telemetry;

namespace NV.Templates.Backend.RestApi.Framework.OpenApi
{
    /// <summary>
    /// <see cref="IOperationProcessor"/> implementation that Adds common headers to all operations.
    /// </summary>
    internal class CommonHeadersOperationProcessor : IOperationProcessor
    {
        /// <inheritdoc />
        public bool Process(OperationProcessorContext context)
        {
            TryAddRequestHeader(context, HttpContextTelemetryInitializer.SessionIdHeader, "The unique identifier for the client session id.");
            TryAddRequestHeader(context, HttpContextTelemetryInitializer.DeviceIdHeader, "The unique identifier for the client device id.");

            foreach (var response in context.OperationDescription.Operation.Responses.Values)
            {
                response.Headers.Add(
                    OperationContextMiddleware.OperationIdHeader,
                    new JsonSchema { Type = JsonObjectType.String });
            }

            return true;
        }

        private void TryAddRequestHeader(OperationProcessorContext context, string name, string description)
        {
            var existingHeader = context.OperationDescription.Operation.Parameters.FirstOrDefault(
                x => x.Kind == OpenApiParameterKind.Header && x.Name.Equals(name, StringComparison.Ordinal));

            if (existingHeader == null)
            {
                context.OperationDescription.Operation.Parameters.Add(new OpenApiParameter
                {
                    Name = name,
                    Description = description,
                    Kind = OpenApiParameterKind.Header,
                    Schema = new JsonSchema { Type = JsonObjectType.String },
                });
            }
        }
    }
}