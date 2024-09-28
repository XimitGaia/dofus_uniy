using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach;

[Token(Token = "0x2000913")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BreachInvitationOfferEvent : IMessage<BreachInvitationOfferEvent>, IMessage, IEquatable<BreachInvitationOfferEvent>, IDeepCloneable<BreachInvitationOfferEvent>, IBufferMessage
{
	[Token(Token = "0x4001F08")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BreachInvitationOfferEvent> _parser;

	[Token(Token = "0x4001F09")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001F0A")]
	public const int HostFieldNumber = 1;

	[Token(Token = "0x4001F0B")]
	[FieldOffset(Offset = "0x18")]
	private Com.Ankama.Dofus.Server.Game.Protocol.Common.Character host_;

	[Token(Token = "0x4001F0C")]
	public const int TimeLeftBeforeCancelFieldNumber = 2;

	[Token(Token = "0x4001F0D")]
	[FieldOffset(Offset = "0x20")]
	private int timeLeftBeforeCancel_;

	[Token(Token = "0x1700144E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BreachInvitationOfferEvent> Parser
	{
		[Token(Token = "0x6005FFD")]
		[Address(RVA = "0xB514D0", Offset = "0xB508D0", VA = "0x180B514D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700144F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005FFE")]
		[Address(RVA = "0xB51420", Offset = "0xB50820", VA = "0x180B51420")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001450")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005FFF")]
		[Address(RVA = "0xB51640", Offset = "0xB50A40", VA = "0x180B51640", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001451")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Com.Ankama.Dofus.Server.Game.Protocol.Common.Character Host
	{
		[Token(Token = "0x6006003")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006004")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001452")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TimeLeftBeforeCancel
	{
		[Token(Token = "0x6006005")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006006")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x6006000")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachInvitationOfferEvent()
	{
	}

	[Token(Token = "0x6006001")]
	[Address(RVA = "0xB513A0", Offset = "0xB507A0", VA = "0x180B513A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachInvitationOfferEvent(BreachInvitationOfferEvent other)
	{
	}

	[Token(Token = "0x6006002")]
	[Address(RVA = "0xB51010", Offset = "0xB50410", VA = "0x180B51010", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachInvitationOfferEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6006007")]
	[Address(RVA = "0xB510C0", Offset = "0xB504C0", VA = "0x180B510C0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006008")]
	[Address(RVA = "0x98AC30", Offset = "0x98A030", VA = "0x18098AC30", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BreachInvitationOfferEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006009")]
	[Address(RVA = "0x98ACA0", Offset = "0x98A0A0", VA = "0x18098ACA0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600600A")]
	[Address(RVA = "0xB51240", Offset = "0xB50640", VA = "0x180B51240", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600600B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600600C")]
	[Address(RVA = "0x9D2390", Offset = "0x9D1790", VA = "0x1809D2390", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600600D")]
	[Address(RVA = "0xB50F50", Offset = "0xB50350", VA = "0x180B50F50", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600600E")]
	[Address(RVA = "0xB51170", Offset = "0xB50570", VA = "0x180B51170", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(BreachInvitationOfferEvent other)
	{
	}

	[Token(Token = "0x600600F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006010")]
	[Address(RVA = "0xB51520", Offset = "0xB50920", VA = "0x180B51520", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
