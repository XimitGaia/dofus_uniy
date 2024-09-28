using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach;

[Token(Token = "0x2000901")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BreachExitResultEvent : IMessage<BreachExitResultEvent>, IMessage, IEquatable<BreachExitResultEvent>, IDeepCloneable<BreachExitResultEvent>, IBufferMessage
{
	[Token(Token = "0x4001ECF")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BreachExitResultEvent> _parser;

	[Token(Token = "0x4001ED0")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001ED1")]
	public const int ExitedFieldNumber = 1;

	[Token(Token = "0x4001ED2")]
	[FieldOffset(Offset = "0x18")]
	private bool exited_;

	[Token(Token = "0x17001426")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BreachExitResultEvent> Parser
	{
		[Token(Token = "0x6005F33")]
		[Address(RVA = "0xB50240", Offset = "0xB4F640", VA = "0x180B50240")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001427")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005F34")]
		[Address(RVA = "0xB50190", Offset = "0xB4F590", VA = "0x180B50190")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001428")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005F35")]
		[Address(RVA = "0xB50290", Offset = "0xB4F690", VA = "0x180B50290", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001429")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Exited
	{
		[Token(Token = "0x6005F39")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005F3A")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6005F36")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BreachExitResultEvent()
	{
	}

	[Token(Token = "0x6005F37")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BreachExitResultEvent(BreachExitResultEvent other)
	{
	}

	[Token(Token = "0x6005F38")]
	[Address(RVA = "0xB4FE80", Offset = "0xB4F280", VA = "0x180B4FE80", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BreachExitResultEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005F3B")]
	[Address(RVA = "0xB4FF00", Offset = "0xB4F300", VA = "0x180B4FF00", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005F3C")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BreachExitResultEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005F3D")]
	[Address(RVA = "0xB4FF90", Offset = "0xB4F390", VA = "0x180B4FF90", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005F3E")]
	[Address(RVA = "0xB50030", Offset = "0xB4F430", VA = "0x180B50030", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005F3F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005F40")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005F41")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005F42")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BreachExitResultEvent other)
	{
	}

	[Token(Token = "0x6005F43")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005F44")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
