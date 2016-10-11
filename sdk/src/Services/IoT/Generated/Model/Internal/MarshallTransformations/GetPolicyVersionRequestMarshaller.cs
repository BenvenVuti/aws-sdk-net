/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetPolicyVersion Request Marshaller
    /// </summary>       
    public class GetPolicyVersionRequestMarshaller : IMarshaller<IRequest, GetPolicyVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetPolicyVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetPolicyVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.HttpMethod = "GET";

            string uriResourcePath = "/policies/{policyName}/version/{policyVersionId}";
            if (!publicRequest.IsSetPolicyName())
                throw new AmazonIoTException("Request object does not have required field PolicyName set");
            uriResourcePath = uriResourcePath.Replace("{policyName}", StringUtils.FromString(publicRequest.PolicyName));
            if (!publicRequest.IsSetPolicyVersionId())
                throw new AmazonIoTException("Request object does not have required field PolicyVersionId set");
            uriResourcePath = uriResourcePath.Replace("{policyVersionId}", StringUtils.FromString(publicRequest.PolicyVersionId));
            request.ResourcePath = uriResourcePath;

            return request;
        }


    }
}