using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterTool
{
    class SkillPartJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(SkillPartBase).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);
            object target = null;

            if (jObject.ContainsKey("effect"))
            {
                target = new AddTriggerPart();
            }
            else if (jObject.ContainsKey("damage"))
            {
                target = new DamagePart();
            }
            else if (jObject.ContainsKey("healing"))
            {
                target = new HealingPart();
            }
            else if (jObject.ContainsKey("direction"))
            {
                target = new MovePart();
            }
            else if (jObject.ContainsKey("affectedStat"))
            {
                target = new StatChangePart();
            }
            else if (jObject.ContainsKey("status"))
            {
                target = new StatusEffectPart();
            }
            else if (jObject.ContainsKey("effectType"))
            {
                target = new UniqueEffectPart();
            }
            else
            {
                throw new ArgumentException("Invalid source type");
            }

            serializer.Populate(jObject.CreateReader(), target);

            return target;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
