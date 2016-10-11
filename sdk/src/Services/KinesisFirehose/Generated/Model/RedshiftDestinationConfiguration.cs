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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Describes the configuration of a destination in Amazon Redshift.
    /// </summary>
    public partial class RedshiftDestinationConfiguration
    {
        private CloudWatchLoggingOptions _cloudWatchLoggingOptions;
        private string _clusterJDBCURL;
        private CopyCommand _copyCommand;
        private string _password;
        private RedshiftRetryOptions _retryOptions;
        private string _roleARN;
        private S3DestinationConfiguration _s3Configuration;
        private string _username;

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOptions. 
        /// <para>
        /// Describes CloudWatch logging options for your delivery stream.
        /// </para>
        /// </summary>
        public CloudWatchLoggingOptions CloudWatchLoggingOptions
        {
            get { return this._cloudWatchLoggingOptions; }
            set { this._cloudWatchLoggingOptions = value; }
        }

        // Check to see if CloudWatchLoggingOptions property is set
        internal bool IsSetCloudWatchLoggingOptions()
        {
            return this._cloudWatchLoggingOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterJDBCURL. 
        /// <para>
        /// The database connection string.
        /// </para>
        /// </summary>
        public string ClusterJDBCURL
        {
            get { return this._clusterJDBCURL; }
            set { this._clusterJDBCURL = value; }
        }

        // Check to see if ClusterJDBCURL property is set
        internal bool IsSetClusterJDBCURL()
        {
            return this._clusterJDBCURL != null;
        }

        /// <summary>
        /// Gets and sets the property CopyCommand. 
        /// <para>
        /// The <code>COPY</code> command.
        /// </para>
        /// </summary>
        public CopyCommand CopyCommand
        {
            get { return this._copyCommand; }
            set { this._copyCommand = value; }
        }

        // Check to see if CopyCommand property is set
        internal bool IsSetCopyCommand()
        {
            return this._copyCommand != null;
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The user password.
        /// </para>
        /// </summary>
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

        /// <summary>
        /// Gets and sets the property RetryOptions. 
        /// <para>
        /// Configures retry behavior in the event that Firehose is unable to deliver documents
        /// to Amazon Redshift. Default value is 3600 (60 minutes).
        /// </para>
        /// </summary>
        public RedshiftRetryOptions RetryOptions
        {
            get { return this._retryOptions; }
            set { this._retryOptions = value; }
        }

        // Check to see if RetryOptions property is set
        internal bool IsSetRetryOptions()
        {
            return this._retryOptions != null;
        }

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The ARN of the AWS credentials.
        /// </para>
        /// </summary>
        public string RoleARN
        {
            get { return this._roleARN; }
            set { this._roleARN = value; }
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._roleARN != null;
        }

        /// <summary>
        /// Gets and sets the property S3Configuration. 
        /// <para>
        /// The S3 configuration for the intermediate location from which Amazon Redshift obtains
        /// data. Restrictions are described in the topic for <a>CreateDeliveryStream</a>.
        /// </para>
        ///  
        /// <para>
        /// The compression formats <code>SNAPPY</code> or <code>ZIP</code> cannot be specified
        /// in <b>RedshiftDestinationConfiguration.S3Configuration</b> because the Amazon Redshift
        /// <code>COPY</code> operation that reads from the S3 bucket doesn't support these compression
        /// formats.
        /// </para>
        /// </summary>
        public S3DestinationConfiguration S3Configuration
        {
            get { return this._s3Configuration; }
            set { this._s3Configuration = value; }
        }

        // Check to see if S3Configuration property is set
        internal bool IsSetS3Configuration()
        {
            return this._s3Configuration != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The name of the user.
        /// </para>
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}