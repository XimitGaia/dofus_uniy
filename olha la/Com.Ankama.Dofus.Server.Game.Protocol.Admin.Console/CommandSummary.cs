using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Admin.Console;

[Token(Token = "0x2000D0C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CommandSummary : IMessage<CommandSummary>, IMessage, IEquatable<CommandSummary>, IDeepCloneable<CommandSummary>, IBufferMessage
{
	[Token(Token = "0x4002FEA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CommandSummary> _parser;

	[Token(Token = "0x4002FEB")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002FEC")]
	public const int CommandFieldNumber = 1;

	[Token(Token = "0x4002FED")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Command> _repeated_command_codec;

	[Token(Token = "0x4002FEE")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Command> command_;

	[Token(Token = "0x17001E02")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CommandSummary> Parser
	{
		[Token(Token = "0x6008961")]
		[Address(RVA = "0xCAF4A0", Offset = "0xCAE8A0", VA = "0x180CAF4A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E03")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008962")]
		[Address(RVA = "0xCAF3F0", Offset = "0xCAE7F0", VA = "0x180CAF3F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E04")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008963")]
		[Address(RVA = "0xCAF6B0", Offset = "0xCAEAB0", VA = "0x180CAF6B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E05")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Command> Command
	{
		[Token(Token = "0x6008967")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008964")]
	[Address(RVA = "0xCAF2E0", Offset = "0xCAE6E0", VA = "0x180CAF2E0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CommandSummary()
	{
	}

	[Token(Token = "0x6008965")]
	[Address(RVA = "0xCAF360", Offset = "0xCAE760", VA = "0x180CAF360")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CommandSummary(CommandSummary other)
	{
	}

	[Token(Token = "0x6008966")]
	[Address(RVA = "0xCAEE30", Offset = "0xCAE230", VA = "0x180CAEE30", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CommandSummary Clone()
	{
		return null;
	}

	[Token(Token = "0x6008968")]
	[Address(RVA = "0xCAEF80", Offset = "0xCAE380", VA = "0x180CAEF80", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008969")]
	[Address(RVA = "0xCAEEF0", Offset = "0xCAE2F0", VA = "0x180CAEEF0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CommandSummary other)
	{
		return default(bool);
	}

	[Token(Token = "0x600896A")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600896B")]
	[Address(RVA = "0xCAF0E0", Offset = "0xCAE4E0", VA = "0x180CAF0E0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600896C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600896D")]
	[Address(RVA = "0xCAF600", Offset = "0xCAEA00", VA = "0x180CAF600", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600896E")]
	[Address(RVA = "0xCAED90", Offset = "0xCAE190", VA = "0x180CAED90", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600896F")]
	[Address(RVA = "0xCAF060", Offset = "0xCAE460", VA = "0x180CAF060", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CommandSummary other)
	{
	}

	[Token(Token = "0x6008970")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008971")]
	[Address(RVA = "0xCAF4F0", Offset = "0xCAE8F0", VA = "0x180CAF4F0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
