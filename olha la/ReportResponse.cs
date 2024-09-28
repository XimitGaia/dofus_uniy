using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

[Token(Token = "0x2000007")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ReportResponse : IMessage<ReportResponse>, IMessage, IEquatable<ReportResponse>, IDeepCloneable<ReportResponse>, IBufferMessage
{
	[Token(Token = "0x2000008")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000009")]
		public enum Error
		{
			[Token(Token = "0x400001C")]
			[OriginalName("UNKNOWN")]
			Unknown,
			[Token(Token = "0x400001D")]
			[OriginalName("SUBSCRIPTION_REQUIRED")]
			SubscriptionRequired,
			[Token(Token = "0x400001E")]
			[OriginalName("BAD_LEVEL")]
			BadLevel,
			[Token(Token = "0x400001F")]
			[OriginalName("LIMIT_EXCEEDED")]
			LimitExceeded,
			[Token(Token = "0x4000020")]
			[OriginalName("NOT_ENABLED")]
			NotEnabled,
			[Token(Token = "0x4000021")]
			[OriginalName("ALREADY_REPORTED")]
			AlreadyReported
		}
	}

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ReportResponse> _parser;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000017")]
	public const int SuccessFieldNumber = 1;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x18")]
	private bool success_;

	[Token(Token = "0x4000019")]
	public const int ErrorFieldNumber = 2;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x1C")]
	private Types.Error error_;

	[Token(Token = "0x17000008")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ReportResponse> Parser
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x940450", Offset = "0x93F850", VA = "0x180940450")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000009")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x9403A0", Offset = "0x93F7A0", VA = "0x1809403A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x9405E0", Offset = "0x93F9E0", VA = "0x1809405E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Success
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.Error Error
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(Types.Error);
		}
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ReportResponse()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x940340", Offset = "0x93F740", VA = "0x180940340")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ReportResponse(ReportResponse other)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x93FF60", Offset = "0x93F360", VA = "0x18093FF60", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ReportResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x93FFF0", Offset = "0x93F3F0", VA = "0x18093FFF0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x940080", Offset = "0x93F480", VA = "0x180940080", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ReportResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x9400C0", Offset = "0x93F4C0", VA = "0x1809400C0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x9401E0", Offset = "0x93F5E0", VA = "0x1809401E0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x940560", Offset = "0x93F960", VA = "0x180940560", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x93FEC0", Offset = "0x93F2C0", VA = "0x18093FEC0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x940180", Offset = "0x93F580", VA = "0x180940180", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ReportResponse other)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x9404A0", Offset = "0x93F8A0", VA = "0x1809404A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
