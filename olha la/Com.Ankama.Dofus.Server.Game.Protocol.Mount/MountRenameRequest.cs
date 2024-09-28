using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount;

[Token(Token = "0x2000303")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MountRenameRequest : IMessage<MountRenameRequest>, IMessage, IEquatable<MountRenameRequest>, IDeepCloneable<MountRenameRequest>, IBufferMessage
{
	[Token(Token = "0x4000A88")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MountRenameRequest> _parser;

	[Token(Token = "0x4000A89")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000A8A")]
	public const int NameFieldNumber = 1;

	[Token(Token = "0x4000A8B")]
	[FieldOffset(Offset = "0x18")]
	private string name_;

	[Token(Token = "0x4000A8C")]
	public const int MountIdFieldNumber = 2;

	[Token(Token = "0x4000A8D")]
	[FieldOffset(Offset = "0x20")]
	private int mountId_;

	[Token(Token = "0x170006BC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MountRenameRequest> Parser
	{
		[Token(Token = "0x6001F41")]
		[Address(RVA = "0xD21990", Offset = "0xD20D90", VA = "0x180D21990")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006BD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001F42")]
		[Address(RVA = "0xD218E0", Offset = "0xD20CE0", VA = "0x180D218E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006BE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001F43")]
		[Address(RVA = "0xD21AB0", Offset = "0xD20EB0", VA = "0x180D21AB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006BF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Name
	{
		[Token(Token = "0x6001F47")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F48")]
		[Address(RVA = "0xD21B90", Offset = "0xD20F90", VA = "0x180D21B90")]
		set
		{
		}
	}

	[Token(Token = "0x170006C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MountId
	{
		[Token(Token = "0x6001F49")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001F4A")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x6001F44")]
	[Address(RVA = "0xD21890", Offset = "0xD20C90", VA = "0x180D21890")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountRenameRequest()
	{
	}

	[Token(Token = "0x6001F45")]
	[Address(RVA = "0xD217E0", Offset = "0xD20BE0", VA = "0x180D217E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountRenameRequest(MountRenameRequest other)
	{
	}

	[Token(Token = "0x6001F46")]
	[Address(RVA = "0xD21490", Offset = "0xD20890", VA = "0x180D21490", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountRenameRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001F4B")]
	[Address(RVA = "0xD21560", Offset = "0xD20960", VA = "0x180D21560", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F4C")]
	[Address(RVA = "0x955090", Offset = "0x954490", VA = "0x180955090", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MountRenameRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F4D")]
	[Address(RVA = "0x955100", Offset = "0x954500", VA = "0x180955100", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001F4E")]
	[Address(RVA = "0xD21680", Offset = "0xD20A80", VA = "0x180D21680", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001F4F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001F50")]
	[Address(RVA = "0x955630", Offset = "0x954A30", VA = "0x180955630", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001F51")]
	[Address(RVA = "0xD213D0", Offset = "0xD207D0", VA = "0x180D213D0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001F52")]
	[Address(RVA = "0xD21610", Offset = "0xD20A10", VA = "0x180D21610", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MountRenameRequest other)
	{
	}

	[Token(Token = "0x6001F53")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001F54")]
	[Address(RVA = "0xD219E0", Offset = "0xD20DE0", VA = "0x180D219E0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
