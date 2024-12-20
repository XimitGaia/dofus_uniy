using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x2000384")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ShortcutBarSwapRequest : IMessage<ShortcutBarSwapRequest>, IMessage, IEquatable<ShortcutBarSwapRequest>, IDeepCloneable<ShortcutBarSwapRequest>, IBufferMessage
{
	[Token(Token = "0x4000C23")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ShortcutBarSwapRequest> _parser;

	[Token(Token = "0x4000C24")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000C25")]
	public const int BarTypeFieldNumber = 1;

	[Token(Token = "0x4000C26")]
	[FieldOffset(Offset = "0x18")]
	private ShortcutBar barType_;

	[Token(Token = "0x4000C27")]
	public const int FirstSlotIdFieldNumber = 2;

	[Token(Token = "0x4000C28")]
	[FieldOffset(Offset = "0x1C")]
	private int firstSlotId_;

	[Token(Token = "0x4000C29")]
	public const int SecondSlotIdFieldNumber = 3;

	[Token(Token = "0x4000C2A")]
	[FieldOffset(Offset = "0x20")]
	private int secondSlotId_;

	[Token(Token = "0x170007D3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ShortcutBarSwapRequest> Parser
	{
		[Token(Token = "0x6002476")]
		[Address(RVA = "0x998420", Offset = "0x997820", VA = "0x180998420")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007D4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002477")]
		[Address(RVA = "0x998370", Offset = "0x997770", VA = "0x180998370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007D5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002478")]
		[Address(RVA = "0x998510", Offset = "0x997910", VA = "0x180998510", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007D6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutBar BarType
	{
		[Token(Token = "0x600247C")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(ShortcutBar);
		}
		[Token(Token = "0x600247D")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170007D7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FirstSlotId
	{
		[Token(Token = "0x600247E")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600247F")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170007D8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SecondSlotId
	{
		[Token(Token = "0x6002480")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002481")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x6002479")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutBarSwapRequest()
	{
	}

	[Token(Token = "0x600247A")]
	[Address(RVA = "0x939530", Offset = "0x938930", VA = "0x180939530")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutBarSwapRequest(ShortcutBarSwapRequest other)
	{
	}

	[Token(Token = "0x600247B")]
	[Address(RVA = "0x998040", Offset = "0x997440", VA = "0x180998040", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutBarSwapRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002482")]
	[Address(RVA = "0x9980D0", Offset = "0x9974D0", VA = "0x1809980D0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002483")]
	[Address(RVA = "0x947820", Offset = "0x946C20", VA = "0x180947820", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ShortcutBarSwapRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002484")]
	[Address(RVA = "0x998170", Offset = "0x997570", VA = "0x180998170", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002485")]
	[Address(RVA = "0x998210", Offset = "0x997610", VA = "0x180998210", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002486")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002487")]
	[Address(RVA = "0x998470", Offset = "0x997870", VA = "0x180998470", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002488")]
	[Address(RVA = "0x997F60", Offset = "0x997360", VA = "0x180997F60", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002489")]
	[Address(RVA = "0x947910", Offset = "0x946D10", VA = "0x180947910", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ShortcutBarSwapRequest other)
	{
	}

	[Token(Token = "0x600248A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600248B")]
	[Address(RVA = "0x947BE0", Offset = "0x946FE0", VA = "0x180947BE0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
