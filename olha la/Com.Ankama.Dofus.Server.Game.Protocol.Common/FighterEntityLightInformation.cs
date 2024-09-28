using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A18")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FighterEntityLightInformation : IMessage<FighterEntityLightInformation>, IMessage, IEquatable<FighterEntityLightInformation>, IDeepCloneable<FighterEntityLightInformation>, IBufferMessage
{
	[Token(Token = "0x4002433")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FighterEntityLightInformation> _parser;

	[Token(Token = "0x4002434")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002435")]
	public const int EntityModelIdFieldNumber = 1;

	[Token(Token = "0x4002436")]
	[FieldOffset(Offset = "0x18")]
	private int entityModelId_;

	[Token(Token = "0x4002437")]
	public const int MasterIdFieldNumber = 2;

	[Token(Token = "0x4002438")]
	[FieldOffset(Offset = "0x20")]
	private long masterId_;

	[Token(Token = "0x170016B5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FighterEntityLightInformation> Parser
	{
		[Token(Token = "0x600695A")]
		[Address(RVA = "0xBC2980", Offset = "0xBC1D80", VA = "0x180BC2980")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016B6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600695B")]
		[Address(RVA = "0xBC28D0", Offset = "0xBC1CD0", VA = "0x180BC28D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016B7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600695C")]
		[Address(RVA = "0xBC29D0", Offset = "0xBC1DD0", VA = "0x180BC29D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016B8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EntityModelId
	{
		[Token(Token = "0x6006960")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006961")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170016B9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long MasterId
	{
		[Token(Token = "0x6006962")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6006963")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x600695D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FighterEntityLightInformation()
	{
	}

	[Token(Token = "0x600695E")]
	[Address(RVA = "0x950DA0", Offset = "0x9501A0", VA = "0x180950DA0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FighterEntityLightInformation(FighterEntityLightInformation other)
	{
	}

	[Token(Token = "0x600695F")]
	[Address(RVA = "0xBC2640", Offset = "0xBC1A40", VA = "0x180BC2640", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FighterEntityLightInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x6006964")]
	[Address(RVA = "0xBC26D0", Offset = "0xBC1AD0", VA = "0x180BC26D0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006965")]
	[Address(RVA = "0x950A70", Offset = "0x94FE70", VA = "0x180950A70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FighterEntityLightInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006966")]
	[Address(RVA = "0x950B50", Offset = "0x94FF50", VA = "0x180950B50", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006967")]
	[Address(RVA = "0xBC2770", Offset = "0xBC1B70", VA = "0x180BC2770", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006968")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006969")]
	[Address(RVA = "0x950F80", Offset = "0x950380", VA = "0x180950F80", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600696A")]
	[Address(RVA = "0xBC2580", Offset = "0xBC1980", VA = "0x180BC2580", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600696B")]
	[Address(RVA = "0x950BE0", Offset = "0x94FFE0", VA = "0x180950BE0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FighterEntityLightInformation other)
	{
	}

	[Token(Token = "0x600696C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600696D")]
	[Address(RVA = "0x950ED0", Offset = "0x9502D0", VA = "0x180950ED0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
