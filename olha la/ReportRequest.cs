using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

[Token(Token = "0x2000003")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ReportRequest : IMessage<ReportRequest>, IMessage, IEquatable<ReportRequest>, IDeepCloneable<ReportRequest>, IBufferMessage
{
	[Token(Token = "0x2000004")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000005")]
		public enum Category
		{
			[Token(Token = "0x400000C")]
			[OriginalName("CHEATING")]
			Cheating,
			[Token(Token = "0x400000D")]
			[OriginalName("ILLEGAL_TRADE")]
			IllegalTrade,
			[Token(Token = "0x400000E")]
			[OriginalName("ILLEGAL_PROMOTE")]
			IllegalPromote,
			[Token(Token = "0x400000F")]
			[OriginalName("EXPLOITING")]
			Exploiting,
			[Token(Token = "0x4000010")]
			[OriginalName("OFFENSIVE_NAME")]
			OffensiveName,
			[Token(Token = "0x4000011")]
			[OriginalName("VERBAL_ABUSE")]
			VerbalAbuse,
			[Token(Token = "0x4000012")]
			[OriginalName("PHISHING")]
			Phishing,
			[Token(Token = "0x4000013")]
			[OriginalName("MONO_ACCOUNT")]
			MonoAccount
		}
	}

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ReportRequest> _parser;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000004")]
	public const int ActorIdFieldNumber = 1;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x18")]
	private long actorId_;

	[Token(Token = "0x4000006")]
	public const int CategoriesFieldNumber = 2;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.Category> _repeated_categories_codec;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<Types.Category> categories_;

	[Token(Token = "0x4000009")]
	public const int DescriptionFieldNumber = 3;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x28")]
	private string description_;

	[Token(Token = "0x17000002")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ReportRequest> Parser
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x93FAB0", Offset = "0x93EEB0", VA = "0x18093FAB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x93FA00", Offset = "0x93EE00", VA = "0x18093FA00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x93FD70", Offset = "0x93F170", VA = "0x18093FD70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000005")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long ActorId
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Types.Category> Categories
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000007")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Description
	{
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x93FE50", Offset = "0x93F250", VA = "0x18093FE50")]
		set
		{
		}
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x93F960", Offset = "0x93ED60", VA = "0x18093F960")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ReportRequest()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x93F8B0", Offset = "0x93ECB0", VA = "0x18093F8B0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ReportRequest(ReportRequest other)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x93F290", Offset = "0x93E690", VA = "0x18093F290", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ReportRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x93F410", Offset = "0x93E810", VA = "0x18093F410", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x93F360", Offset = "0x93E760", VA = "0x18093F360", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ReportRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x93F500", Offset = "0x93E900", VA = "0x18093F500", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x93F660", Offset = "0x93EA60", VA = "0x18093F660", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x93FC70", Offset = "0x93F070", VA = "0x18093FC70", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x93F170", Offset = "0x93E570", VA = "0x18093F170", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x93F5B0", Offset = "0x93E9B0", VA = "0x18093F5B0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ReportRequest other)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x93FB00", Offset = "0x93EF00", VA = "0x18093FB00", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
