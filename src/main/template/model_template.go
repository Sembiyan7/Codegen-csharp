// {{classname}} {{{description}}}{{^description}}struct for {{{classname}}}{{/description}}
type {{classname}} struct {
{{#parent}}
{{^isMap}}
{{^isArray}}
	{{{parent}}}
{{/isArray}}
{{/isMap}}
{{#isArray}}
	Items {{{parent}}}
{{/isArray}}
{{/parent}}
{{#vars}}
{{^-first}}
{{/-first}}
{{#description}}
	// {{{.}}}
{{/description}}
{{#deprecated}}
	// Deprecated
{{/deprecated}}
	{{name}} {{^required}}{{^isNullable}}{{^isArray}}{{^isFreeFormObject}}*{{/isFreeFormObject}}{{/isArray}}{{/isNullable}}{{/required}}{{{dataType}}} `json:"{{baseName}}{{^required}},omitempty{{/required}}"{{#withXml}} xml:"{{baseName}}{{#isXmlAttribute}},attr{{/isXmlAttribute}}"{{/withXml}}{{#vendorExtensions.x-go-custom-tag}} {{{.}}}{{/vendorExtensions.x-go-custom-tag}}`
{{/vars}}
{{#isAdditionalPropertiesTrue}}
	AdditionalProperties map[string]interface{}
{{/isAdditionalPropertiesTrue}}
}

{{#isAdditionalPropertiesTrue}}
type _{{{classname}}} {{{classname}}}

{{/isAdditionalPropertiesTrue}}
// New{{classname}} instantiates a new {{classname}} object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
