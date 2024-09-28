using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment;

[Token(Token = "0x2000C6A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceApplicationInformationEvent : IMessage<AllianceApplicationInformationEvent>, IMessage, IEquatable<AllianceApplicationInformationEvent>, IDeepCloneable<AllianceApplicationInformationEvent>, IBufferMessage
{
	[Token(Token = "0x4002DE4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceApplicationInformationEvent> _parser;

	[Token(Token = "0x4002DE5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002DE6")]
	public const int AllianceFieldNumber = 1;

	[Token(Token = "0x4002DE7")]
	[FieldOffset(Offset = "0x18")]
	private AllianceInformation alliance_;

	[Token(Token = "0x4002DE8")]
	public const int ApplicationInformationFieldNumber = 2;

	[Token(Token = "0x4002DE9")]
	[FieldOffset(Offset = "0x20")]
	private SocialApplicationInformation applicationInformation_;

	[Token(Token = "0x17001C9F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceApplicationInformationEvent> Parser
	{
		[Token(Token = "0x600829F")]
		[Address(RVA = "0xC6FE80", Offset = "0xC6F280", VA = "0x180C6FE80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CA0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60082A0")]
		[Address(RVA = "0xC6FDD0", Offset = "0xC6F1D0", VA = "0x180C6FDD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CA1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60082A1")]
		[Address(RVA = "0xC70020", Offset = "0xC6F420", VA = "0x180C70020", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CA2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceInformation Alliance
	{
		[Token(Token = "0x60082A5")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60082A6")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001CA3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SocialApplicationInformation ApplicationInformation
	{
		[Token(Token = "0x60082A7")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60082A8")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x60082A2")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceApplicationInformationEvent()
	{
	}

	[Token(Token = "0x60082A3")]
	[Address(RVA = "0xC6FD30", Offset = "0xC6F130", VA = "0x180C6FD30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceApplicationInformationEvent(AllianceApplicationInformationEvent other)
	{
	}

	[Token(Token = "0x60082A4")]
	[Address(RVA = "0xC6F910", Offset = "0xC6ED10", VA = "0x180C6F910", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceApplicationInformationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60082A9")]
	[Address(RVA = "0xC6F9E0", Offset = "0xC6EDE0", VA = "0x180C6F9E0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60082AA")]
	[Address(RVA = "0x96C3C0", Offset = "0x96B7C0", VA = "0x18096C3C0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AllianceApplicationInformationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60082AB")]
	[Address(RVA = "0x96C500", Offset = "0x96B900", VA = "0x18096C500", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60082AC")]
	[Address(RVA = "0xC6FBD0", Offset = "0xC6EFD0", VA = "0x180C6FBD0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60082AD")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60082AE")]
	[Address(RVA = "0x96CB10", Offset = "0x96BF10", VA = "0x18096CB10", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60082AF")]
	[Address(RVA = "0xC6F850", Offset = "0xC6EC50", VA = "0x180C6F850", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60082B0")]
	[Address(RVA = "0xC6FAA0", Offset = "0xC6EEA0", VA = "0x180C6FAA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceApplicationInformationEvent other)
	{
	}

	[Token(Token = "0x60082B1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60082B2")]
	[Address(RVA = "0xC6FED0", Offset = "0xC6F2D0", VA = "0x180C6FED0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
