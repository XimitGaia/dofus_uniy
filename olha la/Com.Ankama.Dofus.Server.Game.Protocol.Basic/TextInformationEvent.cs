using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic;

[Token(Token = "0x2000B48")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TextInformationEvent : IMessage<TextInformationEvent>, IMessage, IEquatable<TextInformationEvent>, IDeepCloneable<TextInformationEvent>, IBufferMessage
{
	[Token(Token = "0x2000B49")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000B4A")]
		public enum TextInformationType
		{
			[Token(Token = "0x4002A2B")]
			[OriginalName("TEXT_INFORMATION_MESSAGE")]
			TextInformationMessage,
			[Token(Token = "0x4002A2C")]
			[OriginalName("TEXT_INFORMATION_ERROR")]
			TextInformationError,
			[Token(Token = "0x4002A2D")]
			[OriginalName("TEXT_INFORMATION_PVP")]
			TextInformationPvp,
			[Token(Token = "0x4002A2E")]
			[OriginalName("TEXT_INFORMATION_FIGHT_LOG")]
			TextInformationFightLog,
			[Token(Token = "0x4002A2F")]
			[OriginalName("TEXT_INFORMATION_POPUP")]
			TextInformationPopup,
			[Token(Token = "0x4002A30")]
			[OriginalName("TEXT_LIVING_OBJECT")]
			TextLivingObject,
			[Token(Token = "0x4002A31")]
			[OriginalName("TEXT_ENTITY_TALK")]
			TextEntityTalk,
			[Token(Token = "0x4002A32")]
			[OriginalName("TEXT_INFORMATION_FIGHT")]
			TextInformationFight,
			[Token(Token = "0x4002A33")]
			[OriginalName("TEXT_INFORMATION_EVENT")]
			TextInformationEvent
		}
	}

	[Token(Token = "0x4002A21")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TextInformationEvent> _parser;

	[Token(Token = "0x4002A22")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002A23")]
	public const int MessageTypeFieldNumber = 1;

	[Token(Token = "0x4002A24")]
	[FieldOffset(Offset = "0x18")]
	private Types.TextInformationType messageType_;

	[Token(Token = "0x4002A25")]
	public const int MessageIdFieldNumber = 2;

	[Token(Token = "0x4002A26")]
	[FieldOffset(Offset = "0x1C")]
	private int messageId_;

	[Token(Token = "0x4002A27")]
	public const int ParametersFieldNumber = 3;

	[Token(Token = "0x4002A28")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<string> _repeated_parameters_codec;

	[Token(Token = "0x4002A29")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<string> parameters_;

	[Token(Token = "0x17001A35")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TextInformationEvent> Parser
	{
		[Token(Token = "0x60076F7")]
		[Address(RVA = "0xC26C90", Offset = "0xC26090", VA = "0x180C26C90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A36")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60076F8")]
		[Address(RVA = "0xC26BE0", Offset = "0xC25FE0", VA = "0x180C26BE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A37")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60076F9")]
		[Address(RVA = "0xC26F20", Offset = "0xC26320", VA = "0x180C26F20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A38")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.TextInformationType MessageType
	{
		[Token(Token = "0x60076FD")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.TextInformationType);
		}
		[Token(Token = "0x60076FE")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001A39")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MessageId
	{
		[Token(Token = "0x60076FF")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007700")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17001A3A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<string> Parameters
	{
		[Token(Token = "0x6007701")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60076FA")]
	[Address(RVA = "0xC26B60", Offset = "0xC25F60", VA = "0x180C26B60")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TextInformationEvent()
	{
	}

	[Token(Token = "0x60076FB")]
	[Address(RVA = "0xC26AC0", Offset = "0xC25EC0", VA = "0x180C26AC0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TextInformationEvent(TextInformationEvent other)
	{
	}

	[Token(Token = "0x60076FC")]
	[Address(RVA = "0xC265A0", Offset = "0xC259A0", VA = "0x180C265A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TextInformationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6007702")]
	[Address(RVA = "0xC26710", Offset = "0xC25B10", VA = "0x180C26710", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007703")]
	[Address(RVA = "0xC26670", Offset = "0xC25A70", VA = "0x180C26670", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TextInformationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007704")]
	[Address(RVA = "0xC26800", Offset = "0xC25C00", VA = "0x180C26800", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007705")]
	[Address(RVA = "0xC26930", Offset = "0xC25D30", VA = "0x180C26930", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007706")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007707")]
	[Address(RVA = "0xC26E30", Offset = "0xC26230", VA = "0x180C26E30", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007708")]
	[Address(RVA = "0xC26490", Offset = "0xC25890", VA = "0x180C26490", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007709")]
	[Address(RVA = "0xC268A0", Offset = "0xC25CA0", VA = "0x180C268A0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TextInformationEvent other)
	{
	}

	[Token(Token = "0x600770A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600770B")]
	[Address(RVA = "0xC26CE0", Offset = "0xC260E0", VA = "0x180C26CE0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
