using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena;

[Token(Token = "0x2000BA2")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ArenaSwitchToFightServerEvent : IMessage<ArenaSwitchToFightServerEvent>, IMessage, IEquatable<ArenaSwitchToFightServerEvent>, IDeepCloneable<ArenaSwitchToFightServerEvent>, IBufferMessage
{
	[Token(Token = "0x4002B68")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ArenaSwitchToFightServerEvent> _parser;

	[Token(Token = "0x4002B69")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002B6A")]
	public const int AddressFieldNumber = 1;

	[Token(Token = "0x4002B6B")]
	[FieldOffset(Offset = "0x18")]
	private string address_;

	[Token(Token = "0x4002B6C")]
	public const int PortsFieldNumber = 2;

	[Token(Token = "0x4002B6D")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_ports_codec;

	[Token(Token = "0x4002B6E")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<int> ports_;

	[Token(Token = "0x4002B6F")]
	public const int TokenFieldNumber = 3;

	[Token(Token = "0x4002B70")]
	[FieldOffset(Offset = "0x28")]
	private string token_;

	[Token(Token = "0x17001AEF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ArenaSwitchToFightServerEvent> Parser
	{
		[Token(Token = "0x6007A51")]
		[Address(RVA = "0xC33A50", Offset = "0xC32E50", VA = "0x180C33A50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007A52")]
		[Address(RVA = "0xC339A0", Offset = "0xC32DA0", VA = "0x180C339A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AF1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007A53")]
		[Address(RVA = "0xC33D40", Offset = "0xC33140", VA = "0x180C33D40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AF2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Address
	{
		[Token(Token = "0x6007A57")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007A58")]
		[Address(RVA = "0xC33E20", Offset = "0xC33220", VA = "0x180C33E20")]
		set
		{
		}
	}

	[Token(Token = "0x17001AF3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> Ports
	{
		[Token(Token = "0x6007A59")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AF4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Token
	{
		[Token(Token = "0x6007A5A")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007A5B")]
		[Address(RVA = "0xC33E90", Offset = "0xC33290", VA = "0x180C33E90")]
		set
		{
		}
	}

	[Token(Token = "0x6007A54")]
	[Address(RVA = "0xC338E0", Offset = "0xC32CE0", VA = "0x180C338E0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ArenaSwitchToFightServerEvent()
	{
	}

	[Token(Token = "0x6007A55")]
	[Address(RVA = "0xC33830", Offset = "0xC32C30", VA = "0x180C33830")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaSwitchToFightServerEvent(ArenaSwitchToFightServerEvent other)
	{
	}

	[Token(Token = "0x6007A56")]
	[Address(RVA = "0xC33290", Offset = "0xC32690", VA = "0x180C33290", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaSwitchToFightServerEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6007A5C")]
	[Address(RVA = "0xC33430", Offset = "0xC32830", VA = "0x180C33430", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007A5D")]
	[Address(RVA = "0xC33370", Offset = "0xC32770", VA = "0x180C33370", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ArenaSwitchToFightServerEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007A5E")]
	[Address(RVA = "0xC33530", Offset = "0xC32930", VA = "0x180C33530", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007A5F")]
	[Address(RVA = "0xC336A0", Offset = "0xC32AA0", VA = "0x180C336A0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007A60")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007A61")]
	[Address(RVA = "0xC33C30", Offset = "0xC33030", VA = "0x180C33C30", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007A62")]
	[Address(RVA = "0xC33170", Offset = "0xC32570", VA = "0x180C33170", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007A63")]
	[Address(RVA = "0xC335F0", Offset = "0xC329F0", VA = "0x180C335F0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ArenaSwitchToFightServerEvent other)
	{
	}

	[Token(Token = "0x6007A64")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007A65")]
	[Address(RVA = "0xC33AA0", Offset = "0xC32EA0", VA = "0x180C33AA0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
