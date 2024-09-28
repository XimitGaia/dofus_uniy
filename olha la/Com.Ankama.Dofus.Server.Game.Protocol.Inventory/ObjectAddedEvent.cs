using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003A7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectAddedEvent : IMessage<ObjectAddedEvent>, IMessage, IEquatable<ObjectAddedEvent>, IDeepCloneable<ObjectAddedEvent>, IBufferMessage
{
	[Token(Token = "0x4000C92")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectAddedEvent> _parser;

	[Token(Token = "0x4000C93")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000C94")]
	public const int ObjectFieldNumber = 1;

	[Token(Token = "0x4000C95")]
	[FieldOffset(Offset = "0x18")]
	private ObjectItemInventory object_;

	[Token(Token = "0x4000C96")]
	public const int OriginFieldNumber = 2;

	[Token(Token = "0x4000C97")]
	[FieldOffset(Offset = "0x20")]
	private ObjectOrigin origin_;

	[Token(Token = "0x17000822")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ObjectAddedEvent> Parser
	{
		[Token(Token = "0x60025FE")]
		[Address(RVA = "0x98B090", Offset = "0x98A490", VA = "0x18098B090")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000823")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60025FF")]
		[Address(RVA = "0x98AFE0", Offset = "0x98A3E0", VA = "0x18098AFE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000824")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002600")]
		[Address(RVA = "0x98B280", Offset = "0x98A680", VA = "0x18098B280", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000825")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectItemInventory Object
	{
		[Token(Token = "0x6002604")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002605")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000826")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectOrigin Origin
	{
		[Token(Token = "0x6002606")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(ObjectOrigin);
		}
		[Token(Token = "0x6002607")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x6002601")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectAddedEvent()
	{
	}

	[Token(Token = "0x6002602")]
	[Address(RVA = "0x98AF60", Offset = "0x98A360", VA = "0x18098AF60")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectAddedEvent(ObjectAddedEvent other)
	{
	}

	[Token(Token = "0x6002603")]
	[Address(RVA = "0x98AAD0", Offset = "0x989ED0", VA = "0x18098AAD0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectAddedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002608")]
	[Address(RVA = "0x98AB80", Offset = "0x989F80", VA = "0x18098AB80", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002609")]
	[Address(RVA = "0x98AC30", Offset = "0x98A030", VA = "0x18098AC30", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ObjectAddedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600260A")]
	[Address(RVA = "0x98ACA0", Offset = "0x98A0A0", VA = "0x18098ACA0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600260B")]
	[Address(RVA = "0x98AE00", Offset = "0x98A200", VA = "0x18098AE00", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600260C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600260D")]
	[Address(RVA = "0x98B200", Offset = "0x98A600", VA = "0x18098B200", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600260E")]
	[Address(RVA = "0x98AA10", Offset = "0x989E10", VA = "0x18098AA10", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600260F")]
	[Address(RVA = "0x98AD30", Offset = "0x98A130", VA = "0x18098AD30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ObjectAddedEvent other)
	{
	}

	[Token(Token = "0x6002610")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002611")]
	[Address(RVA = "0x98B0E0", Offset = "0x98A4E0", VA = "0x18098B0E0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
