using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A07")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SocialFightInformation : IMessage<SocialFightInformation>, IMessage, IEquatable<SocialFightInformation>, IDeepCloneable<SocialFightInformation>, IBufferMessage
{
	[Token(Token = "0x2000A08")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000A09")]
		public enum Type
		{
			[Token(Token = "0x40023ED")]
			[OriginalName("TAX_COLLECTOR")]
			TaxCollector,
			[Token(Token = "0x40023EE")]
			[OriginalName("PRISM")]
			Prism
		}
	}

	[Token(Token = "0x40023E4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SocialFightInformation> _parser;

	[Token(Token = "0x40023E5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40023E6")]
	public const int FightIdFieldNumber = 1;

	[Token(Token = "0x40023E7")]
	[FieldOffset(Offset = "0x18")]
	private int fightId_;

	[Token(Token = "0x40023E8")]
	public const int FightTypeFieldNumber = 2;

	[Token(Token = "0x40023E9")]
	[FieldOffset(Offset = "0x1C")]
	private Types.Type fightType_;

	[Token(Token = "0x40023EA")]
	public const int MapIdFieldNumber = 3;

	[Token(Token = "0x40023EB")]
	[FieldOffset(Offset = "0x20")]
	private long mapId_;

	[Token(Token = "0x1700168A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SocialFightInformation> Parser
	{
		[Token(Token = "0x60068B2")]
		[Address(RVA = "0xBB10C0", Offset = "0xBB04C0", VA = "0x180BB10C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700168B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60068B3")]
		[Address(RVA = "0xBB1010", Offset = "0xBB0410", VA = "0x180BB1010")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700168C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60068B4")]
		[Address(RVA = "0xBB1110", Offset = "0xBB0510", VA = "0x180BB1110", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700168D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FightId
	{
		[Token(Token = "0x60068B8")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60068B9")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700168E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.Type FightType
	{
		[Token(Token = "0x60068BA")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(Types.Type);
		}
		[Token(Token = "0x60068BB")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x1700168F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long MapId
	{
		[Token(Token = "0x60068BC")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60068BD")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x60068B5")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SocialFightInformation()
	{
	}

	[Token(Token = "0x60068B6")]
	[Address(RVA = "0x962830", Offset = "0x961C30", VA = "0x180962830")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SocialFightInformation(SocialFightInformation other)
	{
	}

	[Token(Token = "0x60068B7")]
	[Address(RVA = "0xBB0D80", Offset = "0xBB0180", VA = "0x180BB0D80", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialFightInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x60068BE")]
	[Address(RVA = "0xBB0E10", Offset = "0xBB0210", VA = "0x180BB0E10", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60068BF")]
	[Address(RVA = "0x962570", Offset = "0x961970", VA = "0x180962570", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SocialFightInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x60068C0")]
	[Address(RVA = "0xA846F0", Offset = "0xA83AF0", VA = "0x180A846F0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60068C1")]
	[Address(RVA = "0xBB0EB0", Offset = "0xBB02B0", VA = "0x180BB0EB0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60068C2")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60068C3")]
	[Address(RVA = "0xA84A00", Offset = "0xA83E00", VA = "0x180A84A00", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60068C4")]
	[Address(RVA = "0xBB0CA0", Offset = "0xBB00A0", VA = "0x180BB0CA0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60068C5")]
	[Address(RVA = "0x962660", Offset = "0x961A60", VA = "0x180962660", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(SocialFightInformation other)
	{
	}

	[Token(Token = "0x60068C6")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60068C7")]
	[Address(RVA = "0x962990", Offset = "0x961D90", VA = "0x180962990", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
