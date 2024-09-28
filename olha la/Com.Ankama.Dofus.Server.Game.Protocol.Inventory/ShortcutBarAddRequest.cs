using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x2000380")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ShortcutBarAddRequest : IMessage<ShortcutBarAddRequest>, IMessage, IEquatable<ShortcutBarAddRequest>, IDeepCloneable<ShortcutBarAddRequest>, IBufferMessage
{
	[Token(Token = "0x4000C15")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ShortcutBarAddRequest> _parser;

	[Token(Token = "0x4000C16")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000C17")]
	public const int BarTypeFieldNumber = 1;

	[Token(Token = "0x4000C18")]
	[FieldOffset(Offset = "0x18")]
	private ShortcutBar barType_;

	[Token(Token = "0x4000C19")]
	public const int ShortcutFieldNumber = 2;

	[Token(Token = "0x4000C1A")]
	[FieldOffset(Offset = "0x20")]
	private Shortcut shortcut_;

	[Token(Token = "0x170007C9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ShortcutBarAddRequest> Parser
	{
		[Token(Token = "0x6002446")]
		[Address(RVA = "0x996590", Offset = "0x995990", VA = "0x180996590")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007CA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002447")]
		[Address(RVA = "0x9964E0", Offset = "0x9958E0", VA = "0x1809964E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007CB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002448")]
		[Address(RVA = "0x996780", Offset = "0x995B80", VA = "0x180996780", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007CC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ShortcutBar BarType
	{
		[Token(Token = "0x600244C")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(ShortcutBar);
		}
		[Token(Token = "0x600244D")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170007CD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Shortcut Shortcut
	{
		[Token(Token = "0x600244E")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x600244F")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6002449")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutBarAddRequest()
	{
	}

	[Token(Token = "0x600244A")]
	[Address(RVA = "0x996470", Offset = "0x995870", VA = "0x180996470")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutBarAddRequest(ShortcutBarAddRequest other)
	{
	}

	[Token(Token = "0x600244B")]
	[Address(RVA = "0x9960F0", Offset = "0x9954F0", VA = "0x1809960F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutBarAddRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002450")]
	[Address(RVA = "0x996190", Offset = "0x995590", VA = "0x180996190", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002451")]
	[Address(RVA = "0x940820", Offset = "0x93FC20", VA = "0x180940820", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ShortcutBarAddRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002452")]
	[Address(RVA = "0x940940", Offset = "0x93FD40", VA = "0x180940940", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002453")]
	[Address(RVA = "0x996310", Offset = "0x995710", VA = "0x180996310", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002454")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002455")]
	[Address(RVA = "0x996700", Offset = "0x995B00", VA = "0x180996700", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002456")]
	[Address(RVA = "0x996030", Offset = "0x995430", VA = "0x180996030", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002457")]
	[Address(RVA = "0x996240", Offset = "0x995640", VA = "0x180996240", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ShortcutBarAddRequest other)
	{
	}

	[Token(Token = "0x6002458")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002459")]
	[Address(RVA = "0x9965E0", Offset = "0x9959E0", VA = "0x1809965E0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
