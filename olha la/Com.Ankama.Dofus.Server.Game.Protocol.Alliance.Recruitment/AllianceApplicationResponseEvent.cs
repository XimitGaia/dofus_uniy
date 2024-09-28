using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment;

[Token(Token = "0x2000C6E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceApplicationResponseEvent : IMessage<AllianceApplicationResponseEvent>, IMessage, IEquatable<AllianceApplicationResponseEvent>, IDeepCloneable<AllianceApplicationResponseEvent>, IBufferMessage
{
	[Token(Token = "0x4002DEE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceApplicationResponseEvent> _parser;

	[Token(Token = "0x4002DEF")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002DF0")]
	public const int AcceptedFieldNumber = 1;

	[Token(Token = "0x4002DF1")]
	[FieldOffset(Offset = "0x18")]
	private bool accepted_;

	[Token(Token = "0x4002DF2")]
	public const int AllianceInformationFieldNumber = 2;

	[Token(Token = "0x4002DF3")]
	[FieldOffset(Offset = "0x20")]
	private AllianceInformation allianceInformation_;

	[Token(Token = "0x17001CA7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceApplicationResponseEvent> Parser
	{
		[Token(Token = "0x60082CB")]
		[Address(RVA = "0xC73EF0", Offset = "0xC732F0", VA = "0x180C73EF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CA8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60082CC")]
		[Address(RVA = "0xC73E40", Offset = "0xC73240", VA = "0x180C73E40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CA9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60082CD")]
		[Address(RVA = "0xC74070", Offset = "0xC73470", VA = "0x180C74070", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CAA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Accepted
	{
		[Token(Token = "0x60082D1")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60082D2")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17001CAB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceInformation AllianceInformation
	{
		[Token(Token = "0x60082D3")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60082D4")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x60082CE")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceApplicationResponseEvent()
	{
	}

	[Token(Token = "0x60082CF")]
	[Address(RVA = "0xC73DD0", Offset = "0xC731D0", VA = "0x180C73DD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceApplicationResponseEvent(AllianceApplicationResponseEvent other)
	{
	}

	[Token(Token = "0x60082D0")]
	[Address(RVA = "0xC73980", Offset = "0xC72D80", VA = "0x180C73980", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceApplicationResponseEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60082D5")]
	[Address(RVA = "0xC73A20", Offset = "0xC72E20", VA = "0x180C73A20", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60082D6")]
	[Address(RVA = "0x9742A0", Offset = "0x9736A0", VA = "0x1809742A0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceApplicationResponseEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60082D7")]
	[Address(RVA = "0xC73AD0", Offset = "0xC72ED0", VA = "0x180C73AD0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60082D8")]
	[Address(RVA = "0xC73C70", Offset = "0xC73070", VA = "0x180C73C70", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60082D9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60082DA")]
	[Address(RVA = "0x9749C0", Offset = "0x973DC0", VA = "0x1809749C0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60082DB")]
	[Address(RVA = "0xC738E0", Offset = "0xC72CE0", VA = "0x180C738E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60082DC")]
	[Address(RVA = "0xC73B90", Offset = "0xC72F90", VA = "0x180C73B90", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceApplicationResponseEvent other)
	{
	}

	[Token(Token = "0x60082DD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60082DE")]
	[Address(RVA = "0xC73F40", Offset = "0xC73340", VA = "0x180C73F40", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
