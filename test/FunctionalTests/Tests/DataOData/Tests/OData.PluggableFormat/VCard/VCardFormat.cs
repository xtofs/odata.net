﻿//---------------------------------------------------------------------
// <copyright file="VCardFormat.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

namespace Microsoft.Test.OData.PluggableFormat.VCard
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.OData;

    public class VCardFormat : ODataFormat
    {
        public override IEnumerable<ODataPayloadKind> DetectPayloadKind(ODataMessageInfo messageInfo, ODataMessageReaderSettings settings)
        {
            throw new System.NotImplementedException();
        }

        public override ODataInputContext CreateInputContext(ODataMessageInfo messageInfo, ODataMessageReaderSettings messageReaderSettings)
        {
            return new VCardInputContext(this, messageInfo.MessageStream, messageInfo.MediaType, messageInfo.Encoding, messageReaderSettings, messageInfo.IsResponse, true, messageInfo.Model, messageInfo.UrlResolver);
        }

        public override ODataOutputContext CreateOutputContext(ODataMessageInfo messageInfo, ODataMessageWriterSettings messageWriterSettings)
        {
            return new VCardOutputContext(this, messageInfo.MessageStream, messageInfo.Encoding, messageWriterSettings, messageInfo.IsResponse, true, messageInfo.Model, messageInfo.UrlResolver);
        }

        public override Task<IEnumerable<ODataPayloadKind>> DetectPayloadKindAsync(ODataMessageInfo messageInfo, ODataMessageReaderSettings settings)
        {
            throw new System.NotImplementedException();
        }

        public override Task<ODataInputContext> CreateInputContextAsync(ODataMessageInfo messageInfo, ODataMessageReaderSettings messageReaderSettings)
        {
            return Task.FromResult<ODataInputContext>(
                new VCardInputContext(
                    this,
                    messageInfo.MessageStream,
                    messageInfo.MediaType,
                    messageInfo.Encoding,
                    messageReaderSettings,
                    messageInfo.IsResponse,
                    /*sync*/ false,
                    messageInfo.Model,
                    messageInfo.UrlResolver));
        }

        public override Task<ODataOutputContext> CreateOutputContextAsync(ODataMessageInfo messageInfo, ODataMessageWriterSettings messageWriterSettings)
        {
            throw new System.NotImplementedException();
        }
    }
}
