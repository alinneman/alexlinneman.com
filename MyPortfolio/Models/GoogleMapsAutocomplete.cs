using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MyPortfolio.Models
{
	[XmlRoot(ElementName = "term")]
	public class Term
	{
		[XmlElement(ElementName = "value")]
		public string Value { get; set; }
		[XmlElement(ElementName = "offset")]
		public string Offset { get; set; }
	}

	[XmlRoot(ElementName = "matched_substring")]
	public class Matched_substring
	{
		[XmlElement(ElementName = "offset")]
		public string Offset { get; set; }
		[XmlElement(ElementName = "length")]
		public string Length { get; set; }
	}

	[XmlRoot(ElementName = "description_matched_substring")]
	public class Description_matched_substring
	{
		[XmlElement(ElementName = "offset")]
		public string Offset { get; set; }
		[XmlElement(ElementName = "length")]
		public string Length { get; set; }
	}

	[XmlRoot(ElementName = "structured_formatting")]
	public class Structured_formatting
	{
		[XmlElement(ElementName = "description")]
		public string Description { get; set; }
		[XmlElement(ElementName = "subdescription")]
		public string Subdescription { get; set; }
		[XmlElement(ElementName = "description_matched_substring")]
		public Description_matched_substring Description_matched_substring { get; set; }
	}

	[XmlRoot(ElementName = "prediction")]
	public class Prediction
	{
		[XmlElement(ElementName = "description")]
		public string Description { get; set; }
		[XmlElement(ElementName = "type")]
		public List<string> Type { get; set; }
		[XmlElement(ElementName = "reference")]
		public string Reference { get; set; }
		[XmlElement(ElementName = "id")]
		public string Id { get; set; }
		[XmlElement(ElementName = "term")]
		public List<Term> Term { get; set; }
		[XmlElement(ElementName = "matched_substring")]
		public Matched_substring Matched_substring { get; set; }
		[XmlElement(ElementName = "place_id")]
		public string Place_id { get; set; }
		[XmlElement(ElementName = "structured_formatting")]
		public Structured_formatting Structured_formatting { get; set; }
	}

	[XmlRoot(ElementName = "AutocompletionResponse")]
	public class AutocompletionResponse
	{
		[XmlElement(ElementName = "status")]
		public string Status { get; set; }
		[XmlElement(ElementName = "prediction")]
		public List<Prediction> Prediction { get; set; }
	}

	public class GoogleMapsAutocomplete
	{
		public AutocompletionResponse AutocompletionResponse { get; set; }
	}
}