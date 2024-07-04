using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Structural.Facade.III
{
    internal class ConverterFacade : IXmlConverter, IJsonConverter, IByteArrayConverter
    {
        private IXmlConverter xmlConverter;
        private IJsonConverter jsonConverter;
        private IByteArrayConverter byteArrayConverter;

        public ConverterFacade(IXmlConverter xmlConverter, IJsonConverter jsonConverter, IByteArrayConverter byteArrayConverter)
        {
            this.xmlConverter = xmlConverter;
            this.jsonConverter = jsonConverter;
            this.byteArrayConverter = byteArrayConverter;
        }

        public byte[] ToByteArray<T>(T obj)
        {
            return byteArrayConverter.ToByteArray(obj);
        }

        public string ToJson<T>(T obj)
        {
            return jsonConverter.ToJson(obj);
        }

        public string ToXml<T>(T obj)
        {
            return xmlConverter.ToXml(obj);
        }
    }
}
