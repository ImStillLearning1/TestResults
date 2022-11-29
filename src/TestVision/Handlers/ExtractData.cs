
using System.Xml;
using TestVisionAPI.Models;

namespace TestVisionAPI.Handlers
{
    public class ExtractData
    {
        private string _folderPath = "C:\\Users\\Mateusz_Czwarno\\source\\repos\\zadanie\\input\\";
        public ExtractData() 
        { 
         
        }

        public List<TestDetailsDto> ExtractDataFromXml()
        {
            List<TestDetailsDto> testDetailsListDto = new List<TestDetailsDto>();
            foreach (string file in Directory.EnumerateFiles(_folderPath, "*.xml"))
            {
                XmlTextReader reader = new XmlTextReader(file);
                TestDetailsDto testDetailsDto = new TestDetailsDto();
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "Protocol") break;
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "Protocol")
                    {
                        if (reader.HasAttributes)
                        {
                            testDetailsDto.CreatedDate = Convert.ToDateTime(reader.GetAttribute("TestDate"));
                        }
                    }
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "TestResult")
                    {
                        if (reader.HasAttributes)
                        {
                            testDetailsDto.SerialNumber = reader.GetAttribute("SerialNumber");
                        }
                        testDetailsDto.TestResult = reader.ReadElementContentAsString();
                    }
                }
                testDetailsListDto.Add(testDetailsDto);
            }
            return testDetailsListDto;
        }

    }
}
