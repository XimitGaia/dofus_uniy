using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x200054E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapComplementaryAnomalyInformation : IMessage<MapComplementaryAnomalyInformation>, IMessage, IEquatable<MapComplementaryAnomalyInformation>, IDeepCloneable<MapComplementaryAnomalyInformation>, IBufferMessage
{
	[Token(Token = "0x4001230")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapComplementaryAnomalyInformation> _parser;

	[Token(Token = "0x4001231")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001232")]
	public const int LevelFieldNumber = 1;

	[Token(Token = "0x4001233")]
	[FieldOffset(Offset = "0x18")]
	private int level_;

	[Token(Token = "0x4001234")]
	public const int ClosingTimeFieldNumber = 2;

	[Token(Token = "0x4001235")]
	[FieldOffset(Offset = "0x20")]
	private long closingTime_;

	[Token(Token = "0x17000BF9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MapComplementaryAnomalyInformation> Parser
	{
		[Token(Token = "0x6003857")]
		[Address(RVA = "0xA02BB0", Offset = "0xA01FB0", VA = "0x180A02BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BFA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003858")]
		[Address(RVA = "0xA02B00", Offset = "0xA01F00", VA = "0x180A02B00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BFB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003859")]
		[Address(RVA = "0xA02C00", Offset = "0xA02000", VA = "0x180A02C00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BFC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Level
	{
		[Token(Token = "0x600385D")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600385E")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000BFD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ClosingTime
	{
		[Token(Token = "0x600385F")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6003860")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x600385A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapComplementaryAnomalyInformation()
	{
	}

	[Token(Token = "0x600385B")]
	[Address(RVA = "0x950DA0", Offset = "0x9501A0", VA = "0x180950DA0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapComplementaryAnomalyInformation(MapComplementaryAnomalyInformation other)
	{
	}

	[Token(Token = "0x600385C")]
	[Address(RVA = "0xA02870", Offset = "0xA01C70", VA = "0x180A02870", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapComplementaryAnomalyInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x6003861")]
	[Address(RVA = "0xA02900", Offset = "0xA01D00", VA = "0x180A02900", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003862")]
	[Address(RVA = "0x950A70", Offset = "0x94FE70", VA = "0x180950A70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapComplementaryAnomalyInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003863")]
	[Address(RVA = "0x950B50", Offset = "0x94FF50", VA = "0x180950B50", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003864")]
	[Address(RVA = "0xA029A0", Offset = "0xA01DA0", VA = "0x180A029A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003865")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003866")]
	[Address(RVA = "0x950F80", Offset = "0x950380", VA = "0x180950F80", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003867")]
	[Address(RVA = "0xA027B0", Offset = "0xA01BB0", VA = "0x180A027B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003868")]
	[Address(RVA = "0x950BE0", Offset = "0x94FFE0", VA = "0x180950BE0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MapComplementaryAnomalyInformation other)
	{
	}

	[Token(Token = "0x6003869")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600386A")]
	[Address(RVA = "0x950ED0", Offset = "0x9502D0", VA = "0x180950ED0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
