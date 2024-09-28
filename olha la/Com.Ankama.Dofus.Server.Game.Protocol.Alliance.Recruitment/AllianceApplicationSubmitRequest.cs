using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment;

[Token(Token = "0x2000C58")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceApplicationSubmitRequest : IMessage<AllianceApplicationSubmitRequest>, IMessage, IEquatable<AllianceApplicationSubmitRequest>, IDeepCloneable<AllianceApplicationSubmitRequest>, IBufferMessage
{
	[Token(Token = "0x4002DB5")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceApplicationSubmitRequest> _parser;

	[Token(Token = "0x4002DB6")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002DB7")]
	public const int AllianceUidFieldNumber = 1;

	[Token(Token = "0x4002DB8")]
	[FieldOffset(Offset = "0x18")]
	private string allianceUid_;

	[Token(Token = "0x4002DB9")]
	public const int TextFieldNumber = 2;

	[Token(Token = "0x4002DBA")]
	[FieldOffset(Offset = "0x20")]
	private string text_;

	[Token(Token = "0x17001C7A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceApplicationSubmitRequest> Parser
	{
		[Token(Token = "0x60081D7")]
		[Address(RVA = "0xC747B0", Offset = "0xC73BB0", VA = "0x180C747B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C7B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60081D8")]
		[Address(RVA = "0xC74700", Offset = "0xC73B00", VA = "0x180C74700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C7C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60081D9")]
		[Address(RVA = "0xC748F0", Offset = "0xC73CF0", VA = "0x180C748F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C7D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string AllianceUid
	{
		[Token(Token = "0x60081DD")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60081DE")]
		[Address(RVA = "0xC749D0", Offset = "0xC73DD0", VA = "0x180C749D0")]
		set
		{
		}
	}

	[Token(Token = "0x17001C7E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Text
	{
		[Token(Token = "0x60081DF")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60081E0")]
		[Address(RVA = "0xC74A40", Offset = "0xC73E40", VA = "0x180C74A40")]
		set
		{
		}
	}

	[Token(Token = "0x60081DA")]
	[Address(RVA = "0xC745B0", Offset = "0xC739B0", VA = "0x180C745B0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceApplicationSubmitRequest()
	{
	}

	[Token(Token = "0x60081DB")]
	[Address(RVA = "0xC74620", Offset = "0xC73A20", VA = "0x180C74620")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceApplicationSubmitRequest(AllianceApplicationSubmitRequest other)
	{
	}

	[Token(Token = "0x60081DC")]
	[Address(RVA = "0xC74210", Offset = "0xC73610", VA = "0x180C74210", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceApplicationSubmitRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60081E1")]
	[Address(RVA = "0xC74310", Offset = "0xC73710", VA = "0x180C74310", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60081E2")]
	[Address(RVA = "0x931D60", Offset = "0x931160", VA = "0x180931D60", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceApplicationSubmitRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60081E3")]
	[Address(RVA = "0x931DE0", Offset = "0x9311E0", VA = "0x180931DE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60081E4")]
	[Address(RVA = "0xC74450", Offset = "0xC73850", VA = "0x180C74450", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60081E5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60081E6")]
	[Address(RVA = "0x932390", Offset = "0x931790", VA = "0x180932390", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60081E7")]
	[Address(RVA = "0xC74150", Offset = "0xC73550", VA = "0x180C74150", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60081E8")]
	[Address(RVA = "0xC743D0", Offset = "0xC737D0", VA = "0x180C743D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AllianceApplicationSubmitRequest other)
	{
	}

	[Token(Token = "0x60081E9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60081EA")]
	[Address(RVA = "0xC74800", Offset = "0xC73C00", VA = "0x180C74800", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
