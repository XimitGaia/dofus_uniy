using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount;

[Token(Token = "0x200032B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MountRidingEvent : IMessage<MountRidingEvent>, IMessage, IEquatable<MountRidingEvent>, IDeepCloneable<MountRidingEvent>, IBufferMessage
{
	[Token(Token = "0x4000AF3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MountRidingEvent> _parser;

	[Token(Token = "0x4000AF4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000AF5")]
	public const int IsRidingFieldNumber = 1;

	[Token(Token = "0x4000AF6")]
	[FieldOffset(Offset = "0x18")]
	private bool isRiding_;

	[Token(Token = "0x17000704")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MountRidingEvent> Parser
	{
		[Token(Token = "0x60020BF")]
		[Address(RVA = "0x97BD90", Offset = "0x97B190", VA = "0x18097BD90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000705")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60020C0")]
		[Address(RVA = "0x97BCE0", Offset = "0x97B0E0", VA = "0x18097BCE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000706")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60020C1")]
		[Address(RVA = "0x97BDE0", Offset = "0x97B1E0", VA = "0x18097BDE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000707")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsRiding
	{
		[Token(Token = "0x60020C5")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60020C6")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x60020C2")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountRidingEvent()
	{
	}

	[Token(Token = "0x60020C3")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountRidingEvent(MountRidingEvent other)
	{
	}

	[Token(Token = "0x60020C4")]
	[Address(RVA = "0x97B9D0", Offset = "0x97ADD0", VA = "0x18097B9D0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountRidingEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60020C7")]
	[Address(RVA = "0x97BA50", Offset = "0x97AE50", VA = "0x18097BA50", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60020C8")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MountRidingEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60020C9")]
	[Address(RVA = "0x97BAE0", Offset = "0x97AEE0", VA = "0x18097BAE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60020CA")]
	[Address(RVA = "0x97BB80", Offset = "0x97AF80", VA = "0x18097BB80", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60020CB")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60020CC")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60020CD")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60020CE")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MountRidingEvent other)
	{
	}

	[Token(Token = "0x60020CF")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60020D0")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
