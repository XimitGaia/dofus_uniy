using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Npc;

[Token(Token = "0x20002DD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class NpcDialogQuestionEvent : IMessage<NpcDialogQuestionEvent>, IMessage, IEquatable<NpcDialogQuestionEvent>, IDeepCloneable<NpcDialogQuestionEvent>, IBufferMessage
{
	[Token(Token = "0x20002DE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x20002DF")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class VisibleReply : IMessage<VisibleReply>, IMessage, IEquatable<VisibleReply>, IDeepCloneable<VisibleReply>, IBufferMessage
		{
			[Token(Token = "0x20002E0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static class Types
			{
				[Token(Token = "0x20002E1")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class ActionInformation : IMessage<ActionInformation>, IMessage, IEquatable<ActionInformation>, IDeepCloneable<ActionInformation>, IBufferMessage
				{
					[Token(Token = "0x4000A1F")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<ActionInformation> _parser;

					[Token(Token = "0x4000A20")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x4000A21")]
					[FieldOffset(Offset = "0x18")]
					private int _hasBits0;

					[Token(Token = "0x4000A22")]
					public const int IdFieldNumber = 1;

					[Token(Token = "0x4000A23")]
					[FieldOffset(Offset = "0x1C")]
					private int id_;

					[Token(Token = "0x4000A24")]
					public const int IsRepeatableFieldNumber = 2;

					[Token(Token = "0x4000A25")]
					[FieldOffset(Offset = "0x8")]
					private static readonly bool IsRepeatableDefaultValue;

					[Token(Token = "0x4000A26")]
					[FieldOffset(Offset = "0x20")]
					private bool isRepeatable_;

					[Token(Token = "0x17000673")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageParser<ActionInformation> Parser
					{
						[Token(Token = "0x6001DDB")]
						[Address(RVA = "0xD19D50", Offset = "0xD19150", VA = "0x180D19D50")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17000674")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6001DDC")]
						[Address(RVA = "0xD19C60", Offset = "0xD19060", VA = "0x180D19C60")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17000675")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x6001DDD")]
						[Address(RVA = "0xD19F20", Offset = "0xD19320", VA = "0x180D19F20", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17000676")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int Id
					{
						[Token(Token = "0x6001DE1")]
						[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x6001DE2")]
						[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
						set
						{
						}
					}

					[Token(Token = "0x17000677")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public bool IsRepeatable
					{
						[Token(Token = "0x6001DE3")]
						[Address(RVA = "0xD19CE0", Offset = "0xD190E0", VA = "0x180D19CE0")]
						get
						{
							return default(bool);
						}
						[Token(Token = "0x6001DE4")]
						[Address(RVA = "0xD19FD0", Offset = "0xD193D0", VA = "0x180D19FD0")]
						set
						{
						}
					}

					[Token(Token = "0x17000678")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public bool HasIsRepeatable
					{
						[Token(Token = "0x6001DE5")]
						[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
						get
						{
							return default(bool);
						}
					}

					[Token(Token = "0x6001DDE")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public ActionInformation()
					{
					}

					[Token(Token = "0x6001DDF")]
					[Address(RVA = "0x92C240", Offset = "0x92B640", VA = "0x18092C240")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public ActionInformation(ActionInformation other)
					{
					}

					[Token(Token = "0x6001DE0")]
					[Address(RVA = "0xD197A0", Offset = "0xD18BA0", VA = "0x180D197A0", Slot = "10")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public ActionInformation Clone()
					{
						return null;
					}

					[Token(Token = "0x6001DE6")]
					[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void ClearIsRepeatable()
					{
					}

					[Token(Token = "0x6001DE7")]
					[Address(RVA = "0xD19830", Offset = "0xD18C30", VA = "0x180D19830", Slot = "0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x6001DE8")]
					[Address(RVA = "0xD198F0", Offset = "0xD18CF0", VA = "0x180D198F0", Slot = "9")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public bool Equals(ActionInformation other)
					{
						return default(bool);
					}

					[Token(Token = "0x6001DE9")]
					[Address(RVA = "0xD19970", Offset = "0xD18D70", VA = "0x180D19970", Slot = "2")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x6001DEA")]
					[Address(RVA = "0xD19AF0", Offset = "0xD18EF0", VA = "0x180D19AF0", Slot = "3")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x6001DEB")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x6001DEC")]
					[Address(RVA = "0xD19E60", Offset = "0xD19260", VA = "0x180D19E60", Slot = "12")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x6001DED")]
					[Address(RVA = "0xD19710", Offset = "0xD18B10", VA = "0x180D19710", Slot = "7")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x6001DEE")]
					[Address(RVA = "0xD19A80", Offset = "0xD18E80", VA = "0x180D19A80", Slot = "4")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(ActionInformation other)
					{
					}

					[Token(Token = "0x6001DEF")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x6001DF0")]
					[Address(RVA = "0xD19DA0", Offset = "0xD191A0", VA = "0x180D19DA0", Slot = "11")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}
			}

			[Token(Token = "0x4000A18")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<VisibleReply> _parser;

			[Token(Token = "0x4000A19")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4000A1A")]
			public const int ReplyIdFieldNumber = 1;

			[Token(Token = "0x4000A1B")]
			[FieldOffset(Offset = "0x18")]
			private int replyId_;

			[Token(Token = "0x4000A1C")]
			public const int ActionsFieldNumber = 2;

			[Token(Token = "0x4000A1D")]
			[FieldOffset(Offset = "0x8")]
			private static readonly FieldCodec<Types.ActionInformation> _repeated_actions_codec;

			[Token(Token = "0x4000A1E")]
			[FieldOffset(Offset = "0x20")]
			private readonly RepeatedField<Types.ActionInformation> actions_;

			[Token(Token = "0x1700066E")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<VisibleReply> Parser
			{
				[Token(Token = "0x6001DC7")]
				[Address(RVA = "0xD31610", Offset = "0xD30A10", VA = "0x180D31610")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700066F")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6001DC8")]
				[Address(RVA = "0xD31590", Offset = "0xD30990", VA = "0x180D31590")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000670")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6001DC9")]
				[Address(RVA = "0xD31860", Offset = "0xD30C60", VA = "0x180D31860", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000671")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int ReplyId
			{
				[Token(Token = "0x6001DCD")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6001DCE")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x17000672")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public RepeatedField<Types.ActionInformation> Actions
			{
				[Token(Token = "0x6001DCF")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6001DCA")]
			[Address(RVA = "0xD31510", Offset = "0xD30910", VA = "0x180D31510")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public VisibleReply()
			{
			}

			[Token(Token = "0x6001DCB")]
			[Address(RVA = "0xD31480", Offset = "0xD30880", VA = "0x180D31480")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public VisibleReply(VisibleReply other)
			{
			}

			[Token(Token = "0x6001DCC")]
			[Address(RVA = "0xD30FB0", Offset = "0xD303B0", VA = "0x180D30FB0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public VisibleReply Clone()
			{
				return null;
			}

			[Token(Token = "0x6001DD0")]
			[Address(RVA = "0xD31070", Offset = "0xD30470", VA = "0x180D31070", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6001DD1")]
			[Address(RVA = "0xD31150", Offset = "0xD30550", VA = "0x180D31150", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(VisibleReply other)
			{
				return default(bool);
			}

			[Token(Token = "0x6001DD2")]
			[Address(RVA = "0x971040", Offset = "0x970440", VA = "0x180971040", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6001DD3")]
			[Address(RVA = "0xD31280", Offset = "0xD30680", VA = "0x180D31280", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6001DD4")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6001DD5")]
			[Address(RVA = "0xD31790", Offset = "0xD30B90", VA = "0x180D31790", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6001DD6")]
			[Address(RVA = "0xD30ED0", Offset = "0xD302D0", VA = "0x180D30ED0", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6001DD7")]
			[Address(RVA = "0xD311F0", Offset = "0xD305F0", VA = "0x180D311F0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(VisibleReply other)
			{
			}

			[Token(Token = "0x6001DD8")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6001DD9")]
			[Address(RVA = "0xD31660", Offset = "0xD30A60", VA = "0x180D31660", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4000A0E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<NpcDialogQuestionEvent> _parser;

	[Token(Token = "0x4000A0F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000A10")]
	public const int MessageIdFieldNumber = 1;

	[Token(Token = "0x4000A11")]
	[FieldOffset(Offset = "0x18")]
	private int messageId_;

	[Token(Token = "0x4000A12")]
	public const int DialogParamsFieldNumber = 2;

	[Token(Token = "0x4000A13")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<string> _repeated_dialogParams_codec;

	[Token(Token = "0x4000A14")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<string> dialogParams_;

	[Token(Token = "0x4000A15")]
	public const int VisibleRepliesFieldNumber = 3;

	[Token(Token = "0x4000A16")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<Types.VisibleReply> _repeated_visibleReplies_codec;

	[Token(Token = "0x4000A17")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<Types.VisibleReply> visibleReplies_;

	[Token(Token = "0x17000668")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NpcDialogQuestionEvent> Parser
	{
		[Token(Token = "0x6001DB2")]
		[Address(RVA = "0xD27A60", Offset = "0xD26E60", VA = "0x180D27A60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000669")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001DB3")]
		[Address(RVA = "0xD279B0", Offset = "0xD26DB0", VA = "0x180D279B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700066A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001DB4")]
		[Address(RVA = "0xD27D50", Offset = "0xD27150", VA = "0x180D27D50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700066B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MessageId
	{
		[Token(Token = "0x6001DB8")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001DB9")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700066C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<string> DialogParams
	{
		[Token(Token = "0x6001DBA")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700066D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Types.VisibleReply> VisibleReplies
	{
		[Token(Token = "0x6001DBB")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001DB5")]
	[Address(RVA = "0xD278F0", Offset = "0xD26CF0", VA = "0x180D278F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public NpcDialogQuestionEvent()
	{
	}

	[Token(Token = "0x6001DB6")]
	[Address(RVA = "0xD27830", Offset = "0xD26C30", VA = "0x180D27830")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcDialogQuestionEvent(NpcDialogQuestionEvent other)
	{
	}

	[Token(Token = "0x6001DB7")]
	[Address(RVA = "0xD27280", Offset = "0xD26680", VA = "0x180D27280", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public NpcDialogQuestionEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001DBC")]
	[Address(RVA = "0xD27430", Offset = "0xD26830", VA = "0x180D27430", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DBD")]
	[Address(RVA = "0xD27370", Offset = "0xD26770", VA = "0x180D27370", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NpcDialogQuestionEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DBE")]
	[Address(RVA = "0x9A8E80", Offset = "0x9A8280", VA = "0x1809A8E80", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001DBF")]
	[Address(RVA = "0xD275F0", Offset = "0xD269F0", VA = "0x180D275F0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001DC0")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001DC1")]
	[Address(RVA = "0xD27C40", Offset = "0xD27040", VA = "0x180D27C40", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001DC2")]
	[Address(RVA = "0xD27160", Offset = "0xD26560", VA = "0x180D27160", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001DC3")]
	[Address(RVA = "0xD27540", Offset = "0xD26940", VA = "0x180D27540", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NpcDialogQuestionEvent other)
	{
	}

	[Token(Token = "0x6001DC4")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001DC5")]
	[Address(RVA = "0xD27AB0", Offset = "0xD26EB0", VA = "0x180D27AB0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
