using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Chat;

[Token(Token = "0x2000850")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChatPrivateCopyMessageEvent : IMessage<ChatPrivateCopyMessageEvent>, IMessage, IEquatable<ChatPrivateCopyMessageEvent>, IDeepCloneable<ChatPrivateCopyMessageEvent>, IBufferMessage
{
	[Token(Token = "0x4001CB1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ChatPrivateCopyMessageEvent> _parser;

	[Token(Token = "0x4001CB2")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001CB3")]
	public const int ContentFieldNumber = 1;

	[Token(Token = "0x4001CB4")]
	[FieldOffset(Offset = "0x18")]
	private string content_;

	[Token(Token = "0x4001CB5")]
	public const int DateFieldNumber = 2;

	[Token(Token = "0x4001CB6")]
	[FieldOffset(Offset = "0x20")]
	private string date_;

	[Token(Token = "0x4001CB7")]
	public const int TargetCharacterIdFieldNumber = 3;

	[Token(Token = "0x4001CB8")]
	[FieldOffset(Offset = "0x28")]
	private long targetCharacterId_;

	[Token(Token = "0x4001CB9")]
	public const int TargetNameFieldNumber = 4;

	[Token(Token = "0x4001CBA")]
	[FieldOffset(Offset = "0x30")]
	private string targetName_;

	[Token(Token = "0x4001CBB")]
	public const int ObjectFieldNumber = 5;

	[Token(Token = "0x4001CBC")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectItemInventory> _repeated_object_codec;

	[Token(Token = "0x4001CBD")]
	[FieldOffset(Offset = "0x38")]
	private readonly RepeatedField<ObjectItemInventory> object_;

	[Token(Token = "0x170012C7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ChatPrivateCopyMessageEvent> Parser
	{
		[Token(Token = "0x6005844")]
		[Address(RVA = "0xB01AD0", Offset = "0xB00ED0", VA = "0x180B01AD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012C8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005845")]
		[Address(RVA = "0xB01A20", Offset = "0xB00E20", VA = "0x180B01A20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012C9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005846")]
		[Address(RVA = "0xB01E70", Offset = "0xB01270", VA = "0x180B01E70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012CA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Content
	{
		[Token(Token = "0x600584A")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600584B")]
		[Address(RVA = "0xB01F50", Offset = "0xB01350", VA = "0x180B01F50")]
		set
		{
		}
	}

	[Token(Token = "0x170012CB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Date
	{
		[Token(Token = "0x600584C")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x600584D")]
		[Address(RVA = "0xB01FC0", Offset = "0xB013C0", VA = "0x180B01FC0")]
		set
		{
		}
	}

	[Token(Token = "0x170012CC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long TargetCharacterId
	{
		[Token(Token = "0x600584E")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600584F")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x170012CD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TargetName
	{
		[Token(Token = "0x6005850")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005851")]
		[Address(RVA = "0xB02030", Offset = "0xB01430", VA = "0x180B02030")]
		set
		{
		}
	}

	[Token(Token = "0x170012CE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ObjectItemInventory> Object
	{
		[Token(Token = "0x6005852")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005847")]
	[Address(RVA = "0xB01880", Offset = "0xB00C80", VA = "0x180B01880")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChatPrivateCopyMessageEvent()
	{
	}

	[Token(Token = "0x6005848")]
	[Address(RVA = "0xB01950", Offset = "0xB00D50", VA = "0x180B01950")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChatPrivateCopyMessageEvent(ChatPrivateCopyMessageEvent other)
	{
	}

	[Token(Token = "0x6005849")]
	[Address(RVA = "0xB01190", Offset = "0xB00590", VA = "0x180B01190", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChatPrivateCopyMessageEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005853")]
	[Address(RVA = "0xB01290", Offset = "0xB00690", VA = "0x180B01290", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005854")]
	[Address(RVA = "0xB013C0", Offset = "0xB007C0", VA = "0x180B013C0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChatPrivateCopyMessageEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005855")]
	[Address(RVA = "0xB014A0", Offset = "0xB008A0", VA = "0x180B014A0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005856")]
	[Address(RVA = "0xB01680", Offset = "0xB00A80", VA = "0x180B01680", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005857")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005858")]
	[Address(RVA = "0xB01D10", Offset = "0xB01110", VA = "0x180B01D10", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005859")]
	[Address(RVA = "0xB01000", Offset = "0xB00400", VA = "0x180B01000", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600585A")]
	[Address(RVA = "0xB015A0", Offset = "0xB009A0", VA = "0x180B015A0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ChatPrivateCopyMessageEvent other)
	{
	}

	[Token(Token = "0x600585B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600585C")]
	[Address(RVA = "0xB01B20", Offset = "0xB00F20", VA = "0x180B01B20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
