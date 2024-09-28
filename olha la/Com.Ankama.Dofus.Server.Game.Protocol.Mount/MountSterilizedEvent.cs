using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount;

[Token(Token = "0x2000313")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MountSterilizedEvent : IMessage<MountSterilizedEvent>, IMessage, IEquatable<MountSterilizedEvent>, IDeepCloneable<MountSterilizedEvent>, IBufferMessage
{
	[Token(Token = "0x4000AB8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MountSterilizedEvent> _parser;

	[Token(Token = "0x4000AB9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000ABA")]
	public const int MountIdFieldNumber = 1;

	[Token(Token = "0x4000ABB")]
	[FieldOffset(Offset = "0x18")]
	private int mountId_;

	[Token(Token = "0x170006DC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MountSterilizedEvent> Parser
	{
		[Token(Token = "0x6001FE3")]
		[Address(RVA = "0xD235E0", Offset = "0xD229E0", VA = "0x180D235E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006DD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001FE4")]
		[Address(RVA = "0xD23530", Offset = "0xD22930", VA = "0x180D23530")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006DE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001FE5")]
		[Address(RVA = "0xD23630", Offset = "0xD22A30", VA = "0x180D23630", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006DF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MountId
	{
		[Token(Token = "0x6001FE9")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001FEA")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6001FE6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountSterilizedEvent()
	{
	}

	[Token(Token = "0x6001FE7")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountSterilizedEvent(MountSterilizedEvent other)
	{
	}

	[Token(Token = "0x6001FE8")]
	[Address(RVA = "0xD232C0", Offset = "0xD226C0", VA = "0x180D232C0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountSterilizedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001FEB")]
	[Address(RVA = "0xD23340", Offset = "0xD22740", VA = "0x180D23340", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FEC")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MountSterilizedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FED")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001FEE")]
	[Address(RVA = "0xD233D0", Offset = "0xD227D0", VA = "0x180D233D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001FEF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001FF0")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001FF1")]
	[Address(RVA = "0xD23230", Offset = "0xD22630", VA = "0x180D23230", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001FF2")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MountSterilizedEvent other)
	{
	}

	[Token(Token = "0x6001FF3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001FF4")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
