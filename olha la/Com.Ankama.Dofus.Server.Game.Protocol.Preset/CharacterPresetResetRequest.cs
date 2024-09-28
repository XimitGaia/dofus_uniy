using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x2000205")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterPresetResetRequest : IMessage<CharacterPresetResetRequest>, IMessage, IEquatable<CharacterPresetResetRequest>, IDeepCloneable<CharacterPresetResetRequest>, IBufferMessage
{
	[Token(Token = "0x40006DD")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterPresetResetRequest> _parser;

	[Token(Token = "0x40006DE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40006DF")]
	public const int UuidFieldNumber = 1;

	[Token(Token = "0x40006E0")]
	[FieldOffset(Offset = "0x18")]
	private string uuid_;

	[Token(Token = "0x17000465")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterPresetResetRequest> Parser
	{
		[Token(Token = "0x600148B")]
		[Address(RVA = "0xCDA600", Offset = "0xCD9A00", VA = "0x180CDA600")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000466")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600148C")]
		[Address(RVA = "0xCDA550", Offset = "0xCD9950", VA = "0x180CDA550")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000467")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600148D")]
		[Address(RVA = "0xCDA710", Offset = "0xCD9B10", VA = "0x180CDA710", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000468")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Uuid
	{
		[Token(Token = "0x6001491")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001492")]
		[Address(RVA = "0xCDA7F0", Offset = "0xCD9BF0", VA = "0x180CDA7F0")]
		set
		{
		}
	}

	[Token(Token = "0x600148E")]
	[Address(RVA = "0xCDA500", Offset = "0xCD9900", VA = "0x180CDA500")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterPresetResetRequest()
	{
	}

	[Token(Token = "0x600148F")]
	[Address(RVA = "0xCDA460", Offset = "0xCD9860", VA = "0x180CDA460")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterPresetResetRequest(CharacterPresetResetRequest other)
	{
	}

	[Token(Token = "0x6001490")]
	[Address(RVA = "0xCDA120", Offset = "0xCD9520", VA = "0x180CDA120", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterPresetResetRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001493")]
	[Address(RVA = "0xCDA1F0", Offset = "0xCD95F0", VA = "0x180CDA1F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001494")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharacterPresetResetRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001495")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001496")]
	[Address(RVA = "0xCDA300", Offset = "0xCD9700", VA = "0x180CDA300", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001497")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001498")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001499")]
	[Address(RVA = "0xCDA090", Offset = "0xCD9490", VA = "0x180CDA090", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600149A")]
	[Address(RVA = "0xCDA2A0", Offset = "0xCD96A0", VA = "0x180CDA2A0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterPresetResetRequest other)
	{
	}

	[Token(Token = "0x600149B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600149C")]
	[Address(RVA = "0xCDA650", Offset = "0xCD9A50", VA = "0x180CDA650", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
