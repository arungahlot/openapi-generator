/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Mammal
    /// </summary>
    [DataContract(Name = "mammal")]
    public partial class Mammal : AbstractOpenAPISchema, IEquatable<Mammal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mammal" /> class.
        /// </summary>
        public Mammal()
        {
            this.IsNullable = true;
            this.SchemaType= "oneOf";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mammal" /> class
        /// with the <see cref="Pig" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Pig.</param>
        public Mammal(Pig actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mammal" /> class
        /// with the <see cref="Whale" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Whale.</param>
        public Mammal(Whale actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mammal" /> class
        /// with the <see cref="Zebra" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Zebra.</param>
        public Mammal(Zebra actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(Pig))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Whale))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Zebra))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: Pig, Whale, Zebra");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `Pig`. If the actual instanct is not `Pig`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Pig</returns>
        public Pig GetPig()
        {
            return (Pig)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Whale`. If the actual instanct is not `Whale`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Whale</returns>
        public Whale GetWhale()
        {
            return (Whale)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Zebra`. If the actual instanct is not `Zebra`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Zebra</returns>
        public Zebra GetZebra()
        {
            return (Zebra)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Mammal {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, _serializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into the object
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        public static Mammal FromJson(string jsonString)
        {
            Mammal newMammal = new Mammal();
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                newMammal.ActualInstance = JsonConvert.DeserializeObject<Pig>(jsonString, newMammal._serializerSettings);
                matchedTypes.Add("Pig");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(String.Format("Failed to deserialize `%s` into Pig: %s", jsonString, exception.ToString()));
            }

            try
            {
                newMammal.ActualInstance = JsonConvert.DeserializeObject<Whale>(jsonString, newMammal._serializerSettings);
                matchedTypes.Add("Whale");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(String.Format("Failed to deserialize `%s` into Whale: %s", jsonString, exception.ToString()));
            }

            try
            {
                newMammal.ActualInstance = JsonConvert.DeserializeObject<Zebra>(jsonString, newMammal._serializerSettings);
                matchedTypes.Add("Zebra");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(String.Format("Failed to deserialize `%s` into Zebra: %s", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }
            
            // deserialization is considered successful at this point if no exception has been thrown.
            return newMammal;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input as Mammal).AreEqual;
        }

        /// <summary>
        /// Returns true if Mammal instances are equal
        /// </summary>
        /// <param name="input">Instance of Mammal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Mammal input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
