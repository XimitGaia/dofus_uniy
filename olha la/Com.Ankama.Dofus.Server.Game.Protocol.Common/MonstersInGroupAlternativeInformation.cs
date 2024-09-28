using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000AC5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonstersInGroupAlternativeInformation : IMessage<MonstersInGroupAlternativeInformation>, IMessage, IEquatable<MonstersInGroupAlternativeInformation>, IDeepCloneable<MonstersInGroupAlternativeInformation>, IBufferMessage
{
	[Token(Token = "0x4002770")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MonstersInGroupAlternativeInformation> _parser;

	[Token(Token = "0x4002771")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002772")]
	public const int PlayerCountFieldNumber = 1;

	[Token(Token = "0x4002773")]
	[FieldOffset(Offset = "0x18")]
	private int playerCount_;

	[Token(Token = "0x4002774")]
	public const int MonstersFieldNumber = 2;

	[Token(Token = "0x4002775")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<MonsterInGroupInformation> _repeated_monsters_codec;

	[Token(Token = "0x4002776")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<MonsterInGroupInformation> monsters_;

	[Token(Token = "0x1700189C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MonstersInGroupAlternativeInformation> Parser
	{
		[Token(Token = "0x60070DA")]
		[Address(RVA = "0xBE56B0", Offset = "0xBE4AB0", VA = "0x180BE56B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700189D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60070DB")]
		[Address(RVA = "0xBE5600", Offset = "0xBE4A00", VA = "0x180BE5600")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700189E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60070DC")]
		[Address(RVA = "0xBE5900", Offset = "0xBE4D00", VA = "0x180BE5900", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700189F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PlayerCount
	{
		[Token(Token = "0x60070E0")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60070E1")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170018A0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<MonsterInGroupInformation> Monsters
	{
		[Token(Token = "0x60070E2")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60070DD")]
	[Address(RVA = "0xBE5580", Offset = "0xBE4980", VA = "0x180BE5580")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonstersInGroupAlternativeInformation()
	{
	}

	[Token(Token = "0x60070DE")]
	[Address(RVA = "0xBE54F0", Offset = "0xBE48F0", VA = "0x180BE54F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonstersInGroupAlternativeInformation(MonstersInGroupAlternativeInformation other)
	{
	}

	[Token(Token = "0x60070DF")]
	[Address(RVA = "0xBE5020", Offset = "0xBE4420", VA = "0x180BE5020", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MonstersInGroupAlternativeInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x60070E3")]
	[Address(RVA = "0xBE50E0", Offset = "0xBE44E0", VA = "0x180BE50E0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60070E4")]
	[Address(RVA = "0xBE51C0", Offset = "0xBE45C0", VA = "0x180BE51C0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MonstersInGroupAlternativeInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x60070E5")]
	[Address(RVA = "0x971040", Offset = "0x970440", VA = "0x180971040", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60070E6")]
	[Address(RVA = "0xBE52F0", Offset = "0xBE46F0", VA = "0x180BE52F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60070E7")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60070E8")]
	[Address(RVA = "0xBE5830", Offset = "0xBE4C30", VA = "0x180BE5830", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60070E9")]
	[Address(RVA = "0xBE4F40", Offset = "0xBE4340", VA = "0x180BE4F40", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60070EA")]
	[Address(RVA = "0xBE5260", Offset = "0xBE4660", VA = "0x180BE5260", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonstersInGroupAlternativeInformation other)
	{
	}

	[Token(Token = "0x60070EB")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60070EC")]
	[Address(RVA = "0xBE5700", Offset = "0xBE4B00", VA = "0x180BE5700", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
