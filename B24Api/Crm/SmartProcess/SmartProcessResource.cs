using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace B24Api.Crm.SmartProcess
{
    public class SmartProcessResource
    {
        private readonly B24ApiGetway b24ApiGetway;
        private readonly int entityTypeId;

        public SmartProcessResource(B24ApiGetway b24ApiGetway, int entityTypeId)
        {
            this.b24ApiGetway = b24ApiGetway;
            this.entityTypeId = entityTypeId;
        }

        public async Task<IEnumerable<FieldDescription>> Fields()
        {
            Dictionary<string, object> data = new()
            {
                { "entityTypeId", entityTypeId }
            };

            string fieldsJson = await b24ApiGetway.RunAction("/crm.item.fields.json", data);
            var paresdFieldList = await JsonSerializer.DeserializeAsync<List<IDictionary<string, object>>>(
                new MemoryStream(Encoding.UTF8.GetBytes(fieldsJson)));

            return await Task.Run(() => {
                return paresdFieldList?.Select(
                    dict => FieldDescriptionFromDict(dict)) ?? new List<FieldDescription>();
            });
        }

        private static FieldDescription FieldDescriptionFromDict(IDictionary<string, object> dict)
        {
            var fieldDescription = new FieldDescription();

            foreach (KeyValuePair<string, object> keyValuePair in dict)
            {
                if (keyValuePair.Key == "title" && keyValuePair.Value is string title)
                {
                    fieldDescription.Title = title;
                }
            }

            return fieldDescription;
        }
    }
}
