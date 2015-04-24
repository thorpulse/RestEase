﻿using RestEase.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestEase
{
    /// <summary>
    /// Called by the generated REST API implementation, this knows how to invoke the API and return a suitable response
    /// </summary>
    public interface IRequester
    {
        /// <summary>
        /// Invoked when the API interface method being called returns a Task
        /// </summary>
        /// <param name="requestInfo">Object holding all information about the request</param>
        /// <returns>Task to return to the API interface caller</returns>
        Task RequestVoidAsync(RequestInfo requestInfo);

        /// <summary>
        /// Invoked when the API interface method being called returns a Task{T}
        /// </summary>
        /// <typeparam name="T">Type of response object expected by the caller</typeparam>
        /// <param name="requestInfo">Object holding all information about the request</param>
        /// <returns>Task to return to the API interface caller</returns>
        Task<T> RequestAsync<T>(RequestInfo requestInfo);

        /// <summary>
        /// Invoked when the API interface method being called returns a Task{HttpResponseMessage}
        /// </summary>
        /// <param name="requestInfo">Object holding all information about the request</param>
        /// <returns>Task to return to the API interface caller</returns>
        Task<HttpResponseMessage> RequestWithResponseMessageAsync(RequestInfo requestInfo);

        /// <summary>
        /// Invoked when the API interface method being called returns a Task{Response{T}}
        /// </summary>
        /// <typeparam name="T">Type of response object expected by the caller</typeparam>
        /// <param name="requestInfo">Object holding all information about the request</param>
        /// <returns>Task to return to the API interface caller</returns>
        Task<Response<T>> RequestWithResponseAsync<T>(RequestInfo requestInfo);
    }
}