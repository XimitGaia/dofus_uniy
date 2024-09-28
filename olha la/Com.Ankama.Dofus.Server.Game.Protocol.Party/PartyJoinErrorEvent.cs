using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x200027E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyJoinErrorEvent : IMessage<PartyJoinErrorEvent>, IMessage, IEquatable<PartyJoinErrorEvent>, IDeepCloneable<PartyJoinErrorEvent>, IBufferMessage
{
	[Token(Token = "0x200027F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000280")]
		public enum PartyJoinError
		{
			[Token(Token = "0x400088D")]
			[OriginalName("UNKNOWN")]
			Unknown,
			[Token(Token = "0x400088E")]
			[OriginalName("PLAYER_NOT_FOUND")]
			PlayerNotFound,
			[Token(Token = "0x400088F")]
			[OriginalName("PARTY_NOT_FOUND")]
			PartyNotFound,
			[Token(Token = "0x4000890")]
			[OriginalName("PARTY_FULL")]
			PartyFull,
			[Token(Token = "0x4000891")]
			[OriginalName("PLAYER_BUSY")]
			PlayerBusy,
			[Token(Token = "0x4000892")]
			[OriginalName("PLAYER_ALREADY_INVITED")]
			PlayerAlreadyInvited,
			[Token(Token = "0x4000893")]
			[OriginalName("PLAYER_TOO_SOLICITED")]
			PlayerTooSolicited,
			[Token(Token = "0x4000894")]
			[OriginalName("PLAYER_LOYAL")]
			PlayerLoyal,
			[Token(Token = "0x4000895")]
			[OriginalName("UNMODIFIABLE")]
			Unmodifiable,
			[Token(Token = "0x4000896")]
			[OriginalName("UNMET_CRITERION")]
			UnmetCriterion,
			[Token(Token = "0x4000897")]
			[OriginalName("NOT_ENOUGH_ROOM")]
			NotEnoughRoom,
			[Token(Token = "0x4000898")]
			[OriginalName("COMPOSITION_CHANGED")]
			CompositionChanged,
			[Token(Token = "0x4000899")]
			[OriginalName("PLAYER_IN_TUTORIAL")]
			PlayerInTutorial
		}
	}

	[Token(Token = "0x4000886")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyJoinErrorEvent> _parser;

	[Token(Token = "0x4000887")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000888")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x4000889")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x400088A")]
	public const int ReasonFieldNumber = 2;

	[Token(Token = "0x400088B")]
	[FieldOffset(Offset = "0x1C")]
	private Types.PartyJoinError reason_;

	[Token(Token = "0x17000579")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PartyJoinErrorEvent> Parser
	{
		[Token(Token = "0x60019A0")]
		[Address(RVA = "0xCF8390", Offset = "0xCF7790", VA = "0x180CF8390")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700057A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60019A1")]
		[Address(RVA = "0xCF82E0", Offset = "0xCF76E0", VA = "0x180CF82E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700057B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60019A2")]
		[Address(RVA = "0xCF83E0", Offset = "0xCF77E0", VA = "0x180CF83E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700057C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PartyId
	{
		[Token(Token = "0x60019A6")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60019A7")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700057D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.PartyJoinError Reason
	{
		[Token(Token = "0x60019A8")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(Types.PartyJoinError);
		}
		[Token(Token = "0x60019A9")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x60019A3")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyJoinErrorEvent()
	{
	}

	[Token(Token = "0x60019A4")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyJoinErrorEvent(PartyJoinErrorEvent other)
	{
	}

	[Token(Token = "0x60019A5")]
	[Address(RVA = "0xCF8060", Offset = "0xCF7460", VA = "0x180CF8060", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyJoinErrorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60019AA")]
	[Address(RVA = "0xCF80F0", Offset = "0xCF74F0", VA = "0x180CF80F0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60019AB")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PartyJoinErrorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60019AC")]
	[Address(RVA = "0x93AAA0", Offset = "0x939EA0", VA = "0x18093AAA0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60019AD")]
	[Address(RVA = "0xCF8180", Offset = "0xCF7580", VA = "0x180CF8180", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60019AE")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60019AF")]
	[Address(RVA = "0xA25CC0", Offset = "0xA250C0", VA = "0x180A25CC0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60019B0")]
	[Address(RVA = "0xCF7FA0", Offset = "0xCF73A0", VA = "0x180CF7FA0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60019B1")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PartyJoinErrorEvent other)
	{
	}

	[Token(Token = "0x60019B2")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60019B3")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
