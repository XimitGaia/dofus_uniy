using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Admin.Console;

[Token(Token = "0x2000D0E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Command : IMessage<Command>, IMessage, IEquatable<Command>, IDeepCloneable<Command>, IBufferMessage
{
	[Token(Token = "0x4002FF0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<Command> _parser;

	[Token(Token = "0x4002FF1")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002FF2")]
	public const int AliasFieldNumber = 1;

	[Token(Token = "0x4002FF3")]
	[FieldOffset(Offset = "0x18")]
	private string alias_;

	[Token(Token = "0x4002FF4")]
	public const int ArgumentsFieldNumber = 2;

	[Token(Token = "0x4002FF5")]
	[FieldOffset(Offset = "0x20")]
	private string arguments_;

	[Token(Token = "0x4002FF6")]
	public const int DescriptionFieldNumber = 3;

	[Token(Token = "0x4002FF7")]
	[FieldOffset(Offset = "0x28")]
	private string description_;

	[Token(Token = "0x17001E06")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<Command> Parser
	{
		[Token(Token = "0x6008976")]
		[Address(RVA = "0xCAFF30", Offset = "0xCAF330", VA = "0x180CAFF30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E07")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008977")]
		[Address(RVA = "0xCAFE80", Offset = "0xCAF280", VA = "0x180CAFE80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E08")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008978")]
		[Address(RVA = "0xCB0170", Offset = "0xCAF570", VA = "0x180CB0170", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E09")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Alias
	{
		[Token(Token = "0x600897C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600897D")]
		[Address(RVA = "0xCB0250", Offset = "0xCAF650", VA = "0x180CB0250")]
		set
		{
		}
	}

	[Token(Token = "0x17001E0A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Arguments
	{
		[Token(Token = "0x600897E")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x600897F")]
		[Address(RVA = "0xCB02C0", Offset = "0xCAF6C0", VA = "0x180CB02C0")]
		set
		{
		}
	}

	[Token(Token = "0x17001E0B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Description
	{
		[Token(Token = "0x6008980")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008981")]
		[Address(RVA = "0xCB0330", Offset = "0xCAF730", VA = "0x180CB0330")]
		set
		{
		}
	}

	[Token(Token = "0x6008979")]
	[Address(RVA = "0xCAFD70", Offset = "0xCAF170", VA = "0x180CAFD70")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Command()
	{
	}

	[Token(Token = "0x600897A")]
	[Address(RVA = "0xCAFE00", Offset = "0xCAF200", VA = "0x180CAFE00")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Command(Command other)
	{
	}

	[Token(Token = "0x600897B")]
	[Address(RVA = "0xCAF890", Offset = "0xCAEC90", VA = "0x180CAF890", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Command Clone()
	{
		return null;
	}

	[Token(Token = "0x6008982")]
	[Address(RVA = "0xCAF940", Offset = "0xCAED40", VA = "0x180CAF940", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008983")]
	[Address(RVA = "0xCAFA20", Offset = "0xCAEE20", VA = "0x180CAFA20", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(Command other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008984")]
	[Address(RVA = "0xCAFAB0", Offset = "0xCAEEB0", VA = "0x180CAFAB0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008985")]
	[Address(RVA = "0xCAFC10", Offset = "0xCAF010", VA = "0x180CAFC10", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008986")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008987")]
	[Address(RVA = "0xCB00B0", Offset = "0xCAF4B0", VA = "0x180CB00B0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008988")]
	[Address(RVA = "0xCAF790", Offset = "0xCAEB90", VA = "0x180CAF790", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008989")]
	[Address(RVA = "0xCAFB70", Offset = "0xCAEF70", VA = "0x180CAFB70", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(Command other)
	{
	}

	[Token(Token = "0x600898A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600898B")]
	[Address(RVA = "0xCAFF80", Offset = "0xCAF380", VA = "0x180CAFF80", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
