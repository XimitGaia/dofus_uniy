using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment;

[Token(Token = "0x2000C5A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceApplicationUpdateRequest : IMessage<AllianceApplicationUpdateRequest>, IMessage, IEquatable<AllianceApplicationUpdateRequest>, IDeepCloneable<AllianceApplicationUpdateRequest>, IBufferMessage
{
	[Token(Token = "0x4002DBC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceApplicationUpdateRequest> _parser;

	[Token(Token = "0x4002DBD")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002DBE")]
	public const int AllianceUidFieldNumber = 1;

	[Token(Token = "0x4002DBF")]
	[FieldOffset(Offset = "0x18")]
	private string allianceUid_;

	[Token(Token = "0x4002DC0")]
	public const int TextFieldNumber = 2;

	[Token(Token = "0x4002DC1")]
	[FieldOffset(Offset = "0x20")]
	private string text_;

	[Token(Token = "0x17001C7F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceApplicationUpdateRequest> Parser
	{
		[Token(Token = "0x60081EF")]
		[Address(RVA = "0xC75110", Offset = "0xC74510", VA = "0x180C75110")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C80")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60081F0")]
		[Address(RVA = "0xC75060", Offset = "0xC74460", VA = "0x180C75060")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C81")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60081F1")]
		[Address(RVA = "0xC75250", Offset = "0xC74650", VA = "0x180C75250", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C82")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string AllianceUid
	{
		[Token(Token = "0x60081F5")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60081F6")]
		[Address(RVA = "0xC75330", Offset = "0xC74730", VA = "0x180C75330")]
		set
		{
		}
	}

	[Token(Token = "0x17001C83")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Text
	{
		[Token(Token = "0x60081F7")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60081F8")]
		[Address(RVA = "0xC753A0", Offset = "0xC747A0", VA = "0x180C753A0")]
		set
		{
		}
	}

	[Token(Token = "0x60081F2")]
	[Address(RVA = "0xC74F10", Offset = "0xC74310", VA = "0x180C74F10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceApplicationUpdateRequest()
	{
	}

	[Token(Token = "0x60081F3")]
	[Address(RVA = "0xC74F80", Offset = "0xC74380", VA = "0x180C74F80")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceApplicationUpdateRequest(AllianceApplicationUpdateRequest other)
	{
	}

	[Token(Token = "0x60081F4")]
	[Address(RVA = "0xC74B70", Offset = "0xC73F70", VA = "0x180C74B70", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceApplicationUpdateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60081F9")]
	[Address(RVA = "0xC74C70", Offset = "0xC74070", VA = "0x180C74C70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60081FA")]
	[Address(RVA = "0x931D60", Offset = "0x931160", VA = "0x180931D60", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceApplicationUpdateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60081FB")]
	[Address(RVA = "0x931DE0", Offset = "0x9311E0", VA = "0x180931DE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60081FC")]
	[Address(RVA = "0xC74DB0", Offset = "0xC741B0", VA = "0x180C74DB0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60081FD")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60081FE")]
	[Address(RVA = "0x932390", Offset = "0x931790", VA = "0x180932390", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60081FF")]
	[Address(RVA = "0xC74AB0", Offset = "0xC73EB0", VA = "0x180C74AB0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008200")]
	[Address(RVA = "0xC74D30", Offset = "0xC74130", VA = "0x180C74D30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AllianceApplicationUpdateRequest other)
	{
	}

	[Token(Token = "0x6008201")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008202")]
	[Address(RVA = "0xC75160", Offset = "0xC74560", VA = "0x180C75160", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
