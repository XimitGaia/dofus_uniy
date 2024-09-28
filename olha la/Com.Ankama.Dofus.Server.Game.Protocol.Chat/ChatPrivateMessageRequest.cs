using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Chat;

[Token(Token = "0x200084D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChatPrivateMessageRequest : IMessage<ChatPrivateMessageRequest>, IMessage, IEquatable<ChatPrivateMessageRequest>, IDeepCloneable<ChatPrivateMessageRequest>, IBufferMessage
{
	[Token(Token = "0x200084E")]
	public enum TargetOneofCase
	{
		[Token(Token = "0x4001CAD")]
		None = 0,
		[Token(Token = "0x4001CAE")]
		Name = 3,
		[Token(Token = "0x4001CAF")]
		Tag = 4
	}

	[Token(Token = "0x4001CA1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ChatPrivateMessageRequest> _parser;

	[Token(Token = "0x4001CA2")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001CA3")]
	public const int ContentFieldNumber = 1;

	[Token(Token = "0x4001CA4")]
	[FieldOffset(Offset = "0x18")]
	private string content_;

	[Token(Token = "0x4001CA5")]
	public const int ObjectFieldNumber = 2;

	[Token(Token = "0x4001CA6")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectItemInventory> _repeated_object_codec;

	[Token(Token = "0x4001CA7")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<ObjectItemInventory> object_;

	[Token(Token = "0x4001CA8")]
	public const int NameFieldNumber = 3;

	[Token(Token = "0x4001CA9")]
	public const int TagFieldNumber = 4;

	[Token(Token = "0x4001CAA")]
	[FieldOffset(Offset = "0x28")]
	private object target_;

	[Token(Token = "0x4001CAB")]
	[FieldOffset(Offset = "0x30")]
	private TargetOneofCase targetCase_;

	[Token(Token = "0x170012BE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChatPrivateMessageRequest> Parser
	{
		[Token(Token = "0x6005825")]
		[Address(RVA = "0xB02EA0", Offset = "0xB022A0", VA = "0x180B02EA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012BF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005826")]
		[Address(RVA = "0xB02D70", Offset = "0xB02170", VA = "0x180B02D70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005827")]
		[Address(RVA = "0xB03330", Offset = "0xB02730", VA = "0x180B03330", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012C1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Content
	{
		[Token(Token = "0x600582B")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600582C")]
		[Address(RVA = "0xB03410", Offset = "0xB02810", VA = "0x180B03410")]
		set
		{
		}
	}

	[Token(Token = "0x170012C2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ObjectItemInventory> Object
	{
		[Token(Token = "0x600582D")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012C3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Name
	{
		[Token(Token = "0x600582E")]
		[Address(RVA = "0xB02E30", Offset = "0xB02230", VA = "0x180B02E30")]
		get
		{
			return null;
		}
		[Token(Token = "0x600582F")]
		[Address(RVA = "0xB03480", Offset = "0xB02880", VA = "0x180B03480")]
		set
		{
		}
	}

	[Token(Token = "0x170012C4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasName
	{
		[Token(Token = "0x6005830")]
		[Address(RVA = "0xB02E20", Offset = "0xB02220", VA = "0x180B02E20")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170012C5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AccountTag Tag
	{
		[Token(Token = "0x6005832")]
		[Address(RVA = "0xB02EF0", Offset = "0xB022F0", VA = "0x180B02EF0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005833")]
		[Address(RVA = "0x91BB40", Offset = "0x91AF40", VA = "0x18091BB40")]
		set
		{
		}
	}

	[Token(Token = "0x170012C6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TargetOneofCase TargetCase
	{
		[Token(Token = "0x6005834")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(TargetOneofCase);
		}
	}

	[Token(Token = "0x6005828")]
	[Address(RVA = "0xB02CD0", Offset = "0xB020D0", VA = "0x180B02CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChatPrivateMessageRequest()
	{
	}

	[Token(Token = "0x6005829")]
	[Address(RVA = "0xB02B90", Offset = "0xB01F90", VA = "0x180B02B90")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChatPrivateMessageRequest(ChatPrivateMessageRequest other)
	{
	}

	[Token(Token = "0x600582A")]
	[Address(RVA = "0xB022B0", Offset = "0xB016B0", VA = "0x180B022B0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChatPrivateMessageRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005831")]
	[Address(RVA = "0xB02290", Offset = "0xB01690", VA = "0x180B02290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearName()
	{
	}

	[Token(Token = "0x6005835")]
	[Address(RVA = "0x91A760", Offset = "0x919B60", VA = "0x18091A760")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearTarget()
	{
	}

	[Token(Token = "0x6005836")]
	[Address(RVA = "0xB02550", Offset = "0xB01950", VA = "0x180B02550", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005837")]
	[Address(RVA = "0xB02420", Offset = "0xB01820", VA = "0x180B02420", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChatPrivateMessageRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005838")]
	[Address(RVA = "0xB026B0", Offset = "0xB01AB0", VA = "0x180B026B0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005839")]
	[Address(RVA = "0xB02990", Offset = "0xB01D90", VA = "0x180B02990", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600583A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600583B")]
	[Address(RVA = "0xB03160", Offset = "0xB02560", VA = "0x180B03160", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600583C")]
	[Address(RVA = "0xB020A0", Offset = "0xB014A0", VA = "0x180B020A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600583D")]
	[Address(RVA = "0xB02840", Offset = "0xB01C40", VA = "0x180B02840", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ChatPrivateMessageRequest other)
	{
	}

	[Token(Token = "0x600583E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600583F")]
	[Address(RVA = "0xB02F50", Offset = "0xB02350", VA = "0x180B02F50", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
