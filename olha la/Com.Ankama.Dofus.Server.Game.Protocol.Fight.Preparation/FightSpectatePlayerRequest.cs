using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation;

[Token(Token = "0x2000615")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightSpectatePlayerRequest : IMessage<FightSpectatePlayerRequest>, IMessage, IEquatable<FightSpectatePlayerRequest>, IDeepCloneable<FightSpectatePlayerRequest>, IBufferMessage
{
	[Token(Token = "0x4001565")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightSpectatePlayerRequest> _parser;

	[Token(Token = "0x4001566")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001567")]
	public const int PlayerIdFieldNumber = 1;

	[Token(Token = "0x4001568")]
	[FieldOffset(Offset = "0x18")]
	private long playerId_;

	[Token(Token = "0x17000DF6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightSpectatePlayerRequest> Parser
	{
		[Token(Token = "0x60040FD")]
		[Address(RVA = "0xA823E0", Offset = "0xA817E0", VA = "0x180A823E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DF7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60040FE")]
		[Address(RVA = "0xA82330", Offset = "0xA81730", VA = "0x180A82330")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DF8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60040FF")]
		[Address(RVA = "0xA82430", Offset = "0xA81830", VA = "0x180A82430", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DF9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long PlayerId
	{
		[Token(Token = "0x6004103")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6004104")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6004100")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightSpectatePlayerRequest()
	{
	}

	[Token(Token = "0x6004101")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightSpectatePlayerRequest(FightSpectatePlayerRequest other)
	{
	}

	[Token(Token = "0x6004102")]
	[Address(RVA = "0xA820C0", Offset = "0xA814C0", VA = "0x180A820C0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightSpectatePlayerRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6004105")]
	[Address(RVA = "0xA82140", Offset = "0xA81540", VA = "0x180A82140", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004106")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightSpectatePlayerRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004107")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004108")]
	[Address(RVA = "0xA821D0", Offset = "0xA815D0", VA = "0x180A821D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004109")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600410A")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600410B")]
	[Address(RVA = "0xA82030", Offset = "0xA81430", VA = "0x180A82030", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600410C")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightSpectatePlayerRequest other)
	{
	}

	[Token(Token = "0x600410D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600410E")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
