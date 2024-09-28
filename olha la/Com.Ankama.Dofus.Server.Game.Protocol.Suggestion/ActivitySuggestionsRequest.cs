using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Suggestion;

[Token(Token = "0x20000F5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ActivitySuggestionsRequest : IMessage<ActivitySuggestionsRequest>, IMessage, IEquatable<ActivitySuggestionsRequest>, IDeepCloneable<ActivitySuggestionsRequest>, IBufferMessage
{
	[Token(Token = "0x4000338")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ActivitySuggestionsRequest> _parser;

	[Token(Token = "0x4000339")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400033A")]
	public const int MinLevelFieldNumber = 1;

	[Token(Token = "0x400033B")]
	[FieldOffset(Offset = "0x18")]
	private int minLevel_;

	[Token(Token = "0x400033C")]
	public const int MaxLevelFieldNumber = 2;

	[Token(Token = "0x400033D")]
	[FieldOffset(Offset = "0x1C")]
	private int maxLevel_;

	[Token(Token = "0x400033E")]
	public const int AreaIdFieldNumber = 3;

	[Token(Token = "0x400033F")]
	[FieldOffset(Offset = "0x20")]
	private int areaId_;

	[Token(Token = "0x4000340")]
	public const int ActivityCategoryIdFieldNumber = 4;

	[Token(Token = "0x4000341")]
	[FieldOffset(Offset = "0x24")]
	private int activityCategoryId_;

	[Token(Token = "0x4000342")]
	public const int CardsNumberFieldNumber = 5;

	[Token(Token = "0x4000343")]
	[FieldOffset(Offset = "0x28")]
	private int cardsNumber_;

	[Token(Token = "0x170001FD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ActivitySuggestionsRequest> Parser
	{
		[Token(Token = "0x600096D")]
		[Address(RVA = "0xA55550", Offset = "0xA54950", VA = "0x180A55550")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001FE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600096E")]
		[Address(RVA = "0xA554A0", Offset = "0xA548A0", VA = "0x180A554A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001FF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600096F")]
		[Address(RVA = "0xA55790", Offset = "0xA54B90", VA = "0x180A55790", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000200")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MinLevel
	{
		[Token(Token = "0x6000973")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000974")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000201")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxLevel
	{
		[Token(Token = "0x6000975")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000976")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000202")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AreaId
	{
		[Token(Token = "0x6000977")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000978")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17000203")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ActivityCategoryId
	{
		[Token(Token = "0x6000979")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600097A")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000204")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CardsNumber
	{
		[Token(Token = "0x600097B")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600097C")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x6000970")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActivitySuggestionsRequest()
	{
	}

	[Token(Token = "0x6000971")]
	[Address(RVA = "0xA55430", Offset = "0xA54830", VA = "0x180A55430")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ActivitySuggestionsRequest(ActivitySuggestionsRequest other)
	{
	}

	[Token(Token = "0x6000972")]
	[Address(RVA = "0xA54FD0", Offset = "0xA543D0", VA = "0x180A54FD0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ActivitySuggestionsRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600097D")]
	[Address(RVA = "0xA55070", Offset = "0xA54470", VA = "0x180A55070", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600097E")]
	[Address(RVA = "0xA55120", Offset = "0xA54520", VA = "0x180A55120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ActivitySuggestionsRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600097F")]
	[Address(RVA = "0xA55170", Offset = "0xA54570", VA = "0x180A55170", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000980")]
	[Address(RVA = "0xA552D0", Offset = "0xA546D0", VA = "0x180A552D0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000981")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000982")]
	[Address(RVA = "0xA556B0", Offset = "0xA54AB0", VA = "0x180A556B0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000983")]
	[Address(RVA = "0xA54EA0", Offset = "0xA542A0", VA = "0x180A54EA0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000984")]
	[Address(RVA = "0xA55250", Offset = "0xA54650", VA = "0x180A55250", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ActivitySuggestionsRequest other)
	{
	}

	[Token(Token = "0x6000985")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000986")]
	[Address(RVA = "0xA555A0", Offset = "0xA549A0", VA = "0x180A555A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
