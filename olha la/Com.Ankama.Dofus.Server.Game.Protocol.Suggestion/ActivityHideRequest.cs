using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Suggestion;

[Token(Token = "0x20000F7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ActivityHideRequest : IMessage<ActivityHideRequest>, IMessage, IEquatable<ActivityHideRequest>, IDeepCloneable<ActivityHideRequest>, IBufferMessage
{
	[Token(Token = "0x4000345")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ActivityHideRequest> _parser;

	[Token(Token = "0x4000346")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000347")]
	public const int ActivityIdFieldNumber = 1;

	[Token(Token = "0x4000348")]
	[FieldOffset(Offset = "0x18")]
	private int activityId_;

	[Token(Token = "0x17000205")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ActivityHideRequest> Parser
	{
		[Token(Token = "0x600098B")]
		[Address(RVA = "0xA53D50", Offset = "0xA53150", VA = "0x180A53D50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000206")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600098C")]
		[Address(RVA = "0xA53CA0", Offset = "0xA530A0", VA = "0x180A53CA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000207")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600098D")]
		[Address(RVA = "0xA53DA0", Offset = "0xA531A0", VA = "0x180A53DA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000208")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ActivityId
	{
		[Token(Token = "0x6000991")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000992")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x600098E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActivityHideRequest()
	{
	}

	[Token(Token = "0x600098F")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ActivityHideRequest(ActivityHideRequest other)
	{
	}

	[Token(Token = "0x6000990")]
	[Address(RVA = "0xA53A30", Offset = "0xA52E30", VA = "0x180A53A30", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ActivityHideRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000993")]
	[Address(RVA = "0xA53AB0", Offset = "0xA52EB0", VA = "0x180A53AB0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000994")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ActivityHideRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000995")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000996")]
	[Address(RVA = "0xA53B40", Offset = "0xA52F40", VA = "0x180A53B40", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000997")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000998")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000999")]
	[Address(RVA = "0xA539A0", Offset = "0xA52DA0", VA = "0x180A539A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600099A")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ActivityHideRequest other)
	{
	}

	[Token(Token = "0x600099B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600099C")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
