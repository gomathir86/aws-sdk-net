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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */

using System;
using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Configuration for accessing Amazon ListSigningCertificates service
    /// </summary>
    public partial class ListSigningCertificatesResponse : ListSigningCertificatesResult, IPageableResponse<SigningCertificate, ListSigningCertificatesRequest>
    {
        /// <summary>
        /// Gets and sets the ListSigningCertificatesResult property.
        /// Represents the output of a ListSigningCertificates operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the ListSigningCertificatesResult class are now available on the ListSigningCertificatesResponse class. You should use the properties on ListSigningCertificatesResponse instead of accessing them through ListSigningCertificatesResult.")]
        public ListSigningCertificatesResult ListSigningCertificatesResult
        {
            get
            {
                return this;
            }
        }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes",
            Justification = "Hide IPageableResponse implementation from being part of the public interface of this type.")]
        bool IPageableResponse<SigningCertificate, ListSigningCertificatesRequest>.MoreResultsAvailable()
        {
            return this.IsTruncated;
        }

        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes",
            Justification = "Hide IPageableResponse implementation from being part of the public interface of this type.")]
        void IPageableResponse<SigningCertificate, ListSigningCertificatesRequest>.SetPaginationTokens(ListSigningCertificatesRequest request)
        {
            
            request.Marker = this.Marker;
        }

        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes",
            Justification = "Hide IPageableResponse implementation from being part of the public interface of this type.")]
        IEnumerable<SigningCertificate> IPageableResponse<SigningCertificate, ListSigningCertificatesRequest>.SelectResult()
        {
            return this.Certificates;
        }
    }
}