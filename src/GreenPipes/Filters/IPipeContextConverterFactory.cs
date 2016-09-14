﻿// Copyright 2007-2016 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace GreenPipes.Filters
{
    public interface IPipeContextConverterFactory<in TInput>
        where TInput : class, PipeContext
    {
        /// <summary>
        /// Given a known input context type, convert it to the correct output 
        /// context type.
        /// </summary>
        /// <typeparam name="TOutput"></typeparam>
        /// <returns></returns>
        IPipeContextConverter<TInput, TOutput> GetConverter<TOutput>()
            where TOutput : class, PipeContext;
    }
}