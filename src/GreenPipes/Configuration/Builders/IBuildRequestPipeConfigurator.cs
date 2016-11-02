﻿// Copyright 2012-2016 Chris Patterson
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
namespace GreenPipes.Builders
{
    using Configurators;


    public interface IBuildRequestPipeConfigurator<TRequest, TResult> :
        IRequestConfigurator<TRequest, TResult>,
        IPipeConnectorSpecification
        where TRequest : class
        where TResult : class
    {
        /// <summary>
        /// Builds the pipe, applying any initial specifications to the front of the pipe
        /// </summary>
        /// <returns></returns>
        IRequestPipe<TRequest> Build(IPipe<ResultContext> resultPipe);
    }
}