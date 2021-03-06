using System;
using System.Runtime.Serialization;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace ServiceStack.WebHost.IntegrationTests.Services
{
	[DataContract]
	public class RequestFilter
	{
		[DataMember]
		public int StatusCode { get; set; }

		[DataMember]
		public string HeaderName { get; set; }

		[DataMember]
		public string HeaderValue { get; set; }
	}

	[DataContract]
	public class RequestFilterResponse
	{
		[DataMember]
		public string Value { get; set; }
	}

	public class StatusCodeService
		: ServiceBase<RequestFilter>, IRequiresRequestContext
	{
		new public IRequestContext RequestContext { get; set; }

		protected override object Run(RequestFilter request)
		{
			return new RequestFilterResponse();
		}
	}
}